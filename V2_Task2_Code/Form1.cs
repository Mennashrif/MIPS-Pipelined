using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archi_Template
{
    public partial class Form1 : Form
    {
        Hashtable data_memories  = new Hashtable();
        Hashtable instruction = new Hashtable();
        int[] arr = new int[32];
        string Pc="1000";
        int v_r1;
        int v_r2;
        int v_w1;
        string WB;
        string M;
        string EX;
        string IF_ID;
        string ID_EX;
        string EX_MEM;
        string MEM_WB;
        int j = 0;
        public Form1()
       
        {
            InitializeComponent();
        }
         public void fetch() 
        {
            IF_ID = Pc +':'+instruction[Pc];
            Pc = (int.Parse(Pc)+4).ToString();
        }
        public void decode()
        {
            string address;
            Control(IF_ID.Substring(5, 6));
            register_file(IF_ID.Substring(11, 5), IF_ID.Substring(16, 5), "0", "0", '0');
            if (IF_ID[21] == '0')
                address = "0000000000000000" + IF_ID.Substring(21, 16);
            else
                address = "1111111111111111" + IF_ID.Substring(21, 16);
            ID_EX = WB +':'+ M +':'+ EX+':'+ v_r1.ToString()+':'+ v_r2.ToString()+':'+ IF_ID.Substring(21, 5)+':'+ IF_ID.Substring(26, 5)+':'+ address;
            
        }
        public void execution()
        {
            string[] var = ID_EX.Split(':');
            string sel= mux( var[4],var[7], var[2][3]);
            string aluop = var[2].Substring(1,2);
            int res = alu(var[3], sel,aluop,var[7].Substring(26,6));
            string res1 = mux(var[6], var[5], var[2][1]);
            EX_MEM = var[0] + ':' + var[1] + ':' + res.ToString() + ':' + var[4] + ':' + res1;

        }
        public void data_access()
        {
            string[] val = EX_MEM.Split(':');
            string res = data_memory(val[1][1], val[1][2], val[2],val[3]);
            MEM_WB = val[0]+ ':' + res + ':' + val[4];

        }
        public void write_back()
        {
            string[] var = MEM_WB.Split(':');
            register_file("0", "0", var[2], var[1], var[0][0]);
        }
        public string data_memory(char mem_write,char mem_read,string res,string writedata)
        {
            if (mem_write == '0' && mem_read == '0')
                return res;
            data_memories[res] = int.Parse(writedata);
            return "0";


        }
        public string mux(string v1,string v2,char selector)
        {
            if (selector == '0')
                return v1;
            return v2;

        }
        public void Control(string op)
        {
            if (op == "000000")
            {
                EX = "1100";
                M = "000";
                WB = "10";
            }
            else
            {
                EX = "X001";
                M = "001";
                WB = "0X";
            }
            
        }
        public int alu(string r1,string r2,string Aluop,string funct)
        {
            if (Aluop == "00")
                return int.Parse(r1) + Convert.ToInt32(r2, 2);
            else if (Aluop == "10")
            {
                if (funct == "100000")
                    return int.Parse(r1) + int.Parse(r2);
                else if (funct == "100010")
                    return int.Parse(r1) - int.Parse(r2);
                else if (funct == "100100")
                    return int.Parse(r1) & int.Parse(r2);
                else if (funct == "100101")
                    return int.Parse(r1) | int.Parse(r2);
            }
                return -1;
        }
        public void register_file(string r1,string r2,string w1,string w_d,char RegWrite)
        {

            if (RegWrite == '0')
            {
                v_r1 = arr[Convert.ToInt32(r1, 2)];
                v_r2 = arr[Convert.ToInt32(r2, 2)];
            }
            else
                arr[Convert.ToInt32(w1, 2)] = int.Parse(w_d);

        }

        private void UserCodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void inializeBtn_Click(object sender, EventArgs e)
        {
            string txt = UserCode.Text;
            
            for (int i = 0; i < txt.Length; i += 39)
            {
                instruction.Add(txt.Substring(i, 4), txt.Substring(i + 5, 32));
            }
            for(int i = 0; i < 1024; i+=4)
            {
                data_memories.Add(i.ToString(),99);
            }
            arr[0] = 0;
            for (int i = 1; i < 32; i++)
                arr[i] = i + 100;
        }

        private void run_Click(object sender, EventArgs e)
        {
          
                if (j >= 4 && j <= 8)
                    write_back();
                if (j >= 3 && j <= 7)
                    data_access();
                if (j >= 2 && j <= 6)
                    execution();
                if (j >= 1 && j <= 5)
                    decode();
                if (j >= 0 && j <= 4)
                    fetch();
                j++;
            
            MipsRegister.Rows.Clear();
            pipeline.Rows.Clear();
            Memory.Rows.Clear();
            for (int i = 0; i < 32; i++)
            {
                MipsRegister.Rows.Add( '$' + i.ToString(),arr[i].ToString());
               
            }
            pipeline.Rows.Add("IF_ID", IF_ID);
            pipeline.Rows.Add("ID_EX", ID_EX);
            pipeline.Rows.Add("EX_MEM", EX_MEM);
            pipeline.Rows.Add("MEM_WB",MEM_WB);
            for (int i = 0; i < 1024; i += 4)
                Memory.Rows.Add(i.ToString(), data_memories[i.ToString()].ToString());


        }
            

    }
}
