using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assembly
{
    public partial class Form1 : Form
    {
        public List<string> list123 = new List<string>();

        String AR = "";
        String PC = "0";
        String IR = "0000";
        String DR = "0000";
        String AC = "0000";
        String Decode = "";
        int SC = 0;
        String I = "";

        public void DictionaryInit(Dictionary<string, string> dictionaryBin)
        {
            // Bin
            dictionaryBin.Add("OR", "0001");
            dictionaryBin.Add("AND", "0010");
            dictionaryBin.Add("XOR", "0011");
            dictionaryBin.Add("ADD", "0100");
            dictionaryBin.Add("LDA", "0101");
            dictionaryBin.Add("STA", "0110");
            dictionaryBin.Add("BUN", "1000");
            dictionaryBin.Add("BSA", "1001");
            dictionaryBin.Add("ISZ", "1111");
            dictionaryBin.Add("CLA", "0001");
            dictionaryBin.Add("SZA", "0010");
            dictionaryBin.Add("SNA", "0011");
            dictionaryBin.Add("CMA", "0100");
            dictionaryBin.Add("INC", "0101");
            dictionaryBin.Add("ASHR", "0111");
            dictionaryBin.Add("ASHL", "1000");
            dictionaryBin.Add("SZE", "0000");
            dictionaryBin.Add("HLT", "1001");
            dictionaryBin.Add("INP", "X111");
            dictionaryBin.Add("Push", "X001");
            dictionaryBin.Add("Pop", "X010");
            dictionaryBin.Add("SZEmpty", "X011");
            dictionaryBin.Add("SZFull", "X100");
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionaryBin = new Dictionary<string, string>();
            DictionaryInit(dictionaryBin);
            String[] commentarray;
            String[] labelarray;
            String[] restArray;
            String Address = "";
            String I = "";
            String Segment = "";
            int lineCount = 0;
            int labelline = 0;
            Boolean lineChanger = false;
            String Binary = "";
            String Hex = "";
            for (int i = 0; i < 20; i++)
            {
                DataGridViewRow row = (DataGridViewRow)DataSegment.Rows[0].Clone();
                row.Cells[0].Value = "0";
                row.Cells[1].Value = "000000000";
                row.Cells[2].Value = "000";
                DataSegment.Rows.Add(row);
            }
            for (int i = 0; i < 20; i++)
            {
                DataGridViewRow row = (DataGridViewRow)StackSegment.Rows[0].Clone();
                row.Cells[0].Value = "0";
                row.Cells[1].Value = "000000000";
                row.Cells[2].Value = "000";
                StackSegment.Rows.Add(row);
            }
            for (int i = 0; i < 20; i++)
            {
                DataGridViewRow row = (DataGridViewRow)CodeSegment.Rows[0].Clone();
                row.Cells[0].Value = "0";
                row.Cells[1].Value = "000000000";
                row.Cells[2].Value = "000";
                CodeSegment.Rows.Add(row);
            } for (int i = 0; i < 20; i++)
            {
                DataGridViewRow row = (DataGridViewRow)LabelGrid.Rows[0].Clone();
                row.Cells[0].Value = "0";
                row.Cells[1].Value = "00";
                LabelGrid.Rows.Add(row);
            }


            //Browse file
            openFileDialog1.Title = "Please select the assembly file";
            openFileDialog1.Filter = "(*.asm)|*.asm|(*.basm)|*.basm";
            openFileDialog1.ShowDialog();
            BrowseBox.Text = openFileDialog1.FileName;
            if (BrowseBox.Text == "") return;
            //Read file into ListBox
            AssemblyCode.Items.Clear();
            using (StreamReader sr = new StreamReader(BrowseBox.Text))
            {
                String line;
                string adres = "";
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {

                    list123.Add(line);
                    commentarray = (line).Split('%');
                    if (commentarray[0].Trim().Substring(0, 3) == "ORG")
                    {
                        adres = commentarray[0].Trim().Substring(4, 1);
                        lineCount = Convert.ToInt16(commentarray[0].Trim().Substring(6, 1));
                    }
                    else if (commentarray[0].Contains(','))
                    {
                        labelarray = commentarray[0].Split(',');
                        LabelGrid.Rows[labelline].Cells[0].Value = labelarray[0].Trim();
                        LabelGrid.Rows[labelline].Cells[1].Value = adres + lineCount.ToString();
                        DataSegment.Rows[lineCount].Cells[0].Value = labelarray[0].Trim();
                        Binary = Convert.ToString(Convert.ToInt16(labelarray[1].Trim().Substring(4, 1)), 2);
                        if (Binary.Length < 2)
                        {
                            Binary = "000" + Binary;
                        }
                        else if (Binary.Length < 3)
                        {
                            Binary = "00" + Binary;
                        }
                        else if (Binary.Length < 4)
                        {
                            Binary = "0" + Binary;
                        }
                        DataSegment.Rows[lineCount].Cells[1].Value = Binary;
                        DataSegment.Rows[lineCount].Cells[2].Value = Convert.ToInt32(Binary, 2).ToString("X");
                        labelline++;
                        lineCount++;
                    }
                }
                lineCount = 0;
                for (int i = 0; i < list123.Count; i++)
                {
                    Binary = "";
                    Hex = "";
                    AssemblyCode.Items.Add(list123[i]);
                    commentarray = (list123[i]).Split('%');
                    if (commentarray[0].Contains(','))
                    {
                        labelarray = commentarray[0].Trim().Split(',');
                        labelarray[0] = labelarray[0].Trim();
                        restArray = labelarray[1].Trim().Split(' ');
                        if (restArray.Length >= 2)
                        {
                            Address = restArray[1].Trim();
                        }
                        if (restArray.Length >= 3)
                        {
                            I = restArray[2].Trim();
                        }
                    }
                    else
                    {
                        restArray = commentarray[0].Trim().Split(' ');
                        if (restArray.Length >= 2)
                        {
                            Address = restArray[1].Trim();
                        }
                        if (restArray.Length >= 3)
                        {
                            I = restArray[2].Trim();
                        }
                    }
                    if (restArray[0].Trim() == "ORG")
                    {
                        Segment = Address;
                        lineChanger = true;
                    }
                    else if (restArray[0].Trim() != "DEC" && restArray[0].Trim() != "HEX" && restArray[0].Trim() != "END")
                    {
                        if (Segment == "C")
                        {
                            if (lineChanger)
                            {
                                lineCount = Convert.ToInt16(I);
                                lineChanger = false;
                            }

                            if (restArray.Length >= 3)
                            {
                                int temp = Convert.ToInt16(restArray[2].Trim());
                                Binary += Convert.ToString(temp, 2);
                                temp = Convert.ToInt16(restArray[2].Trim());
                                Hex += Convert.ToString(temp, 2);

                            }
                            else
                            {
                                Binary += "0";
                                Hex += "0";
                            }
                            Binary += dictionaryBin[restArray[0].Trim()];
                            //Hex += Convert.ToInt32(Binary, 2).ToString("X");
                            if (restArray.Length < 2)
                            {
                                Hex += Convert.ToInt32(Binary, 2).ToString("X");
                            }
                            else
                            {
                                for (int j = 0; j < LabelGrid.RowCount; j++)
                                {
                                    if (LabelGrid.Rows[j].Cells[0].Value != null)
                                    {
                                        String temp = LabelGrid.Rows[j].Cells[0].Value.ToString();
                                        if (restArray[1].Trim() == temp)
                                        {
                                            if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 2)
                                            {
                                                Binary += "000";
                                            }
                                            else if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 3)
                                            {
                                                Binary += "00";
                                            }
                                            else if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 4)
                                            {
                                                Binary += "0";
                                            }
                                            Binary += Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2);
                                            Hex += Convert.ToInt32(Binary, 2).ToString("X");
                                            break;
                                        }
                                    }
                                }
                            }

                            CodeSegment.Rows[lineCount].Cells[0].Value = lineCount;
                            CodeSegment.Rows[lineCount].Cells[1].Value = Binary;
                            CodeSegment.Rows[lineCount].Cells[2].Value = Hex;
                            lineCount++;
                        }
                        else if (Segment == "D")
                        {
                            if (lineChanger)
                            {
                                lineCount = Convert.ToInt16(I);
                                lineChanger = false;
                            }
                            if (restArray.Length >= 3)
                            {
                                int temp = Convert.ToInt16(restArray[2].Trim());
                                Binary += Convert.ToString(temp, 2);
                                temp = Convert.ToInt16(restArray[2].Trim());
                                Hex += Convert.ToString(temp, 2);

                            }
                            else
                            {
                                Binary += "0";
                                Hex += "0";
                            }
                            Binary += dictionaryBin[restArray[0].Trim()];
                            //Hex += Convert.ToInt32(Binary, 2).ToString("X");
                            if (restArray.Length < 2)
                            {
                                Hex += Convert.ToInt32(Binary, 2).ToString("X");
                            }
                            else
                            {
                                for (int j = 0; j < LabelGrid.RowCount; j++)
                                {
                                    if (LabelGrid.Rows[j].Cells[0].Value != null)
                                    {
                                        String temp = LabelGrid.Rows[j].Cells[0].Value.ToString();
                                        if (restArray[1].Trim() == temp)
                                        {
                                            if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 2)
                                            {
                                                Binary += "000";
                                            }
                                            else if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 3)
                                            {
                                                Binary += "00";
                                            }
                                            else if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 4)
                                            {
                                                Binary += "0";
                                            }
                                            Binary += Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2);
                                            Hex += Convert.ToInt32(Binary, 2).ToString("X");
                                            break;
                                        }
                                    }
                                }
                            }


                            DataSegment.Rows[lineCount].Cells[0].Value = lineCount;
                            DataSegment.Rows[lineCount].Cells[1].Value = Binary;
                            DataSegment.Rows[lineCount].Cells[2].Value = Hex;
                            lineCount++;
                        }
                        else if (Segment == "S")
                        {
                            if (lineChanger)
                            {
                                lineCount = Convert.ToInt16(I);
                                lineChanger = false;
                            }
                            if (restArray.Length >= 3)
                            {
                                int temp = Convert.ToInt16(restArray[2].Trim());
                                Binary += Convert.ToString(temp, 2);
                                temp = Convert.ToInt16(restArray[2].Trim());
                                Hex += Convert.ToString(temp, 2);

                            }
                            else
                            {
                                Binary += "0";
                                Hex += "0";
                            }
                            Binary += dictionaryBin[restArray[0].Trim()];
                            //Hex += Convert.ToInt32(Binary, 2).ToString("X");
                            if (restArray.Length < 2)
                            {
                                Hex += Convert.ToInt32(Binary, 2).ToString("X");
                            }
                            else
                            {
                                for (int j = 0; j < LabelGrid.RowCount; j++)
                                {
                                    if (LabelGrid.Rows[j].Cells[0].Value != null)
                                    {
                                        String temp = LabelGrid.Rows[j].Cells[0].Value.ToString();
                                        if (restArray[1].Trim() == temp)
                                        {
                                            if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 2)
                                            {
                                                Binary += "000";
                                            }
                                            else if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 3)
                                            {
                                                Binary += "00";
                                            }
                                            else if (Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2).Length < 4)
                                            {
                                                Binary += "0";
                                            }
                                            Binary += Convert.ToString(Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Trim().Substring(1, 1)), 2);
                                            Hex += Convert.ToInt32(Binary, 2).ToString("X");
                                            break;
                                        }
                                    }
                                }
                            }


                            StackSegment.Rows[lineCount].Cells[0].Value = lineCount;
                            StackSegment.Rows[lineCount].Cells[1].Value = Binary;
                            StackSegment.Rows[lineCount].Cells[2].Value = Hex;
                            lineCount++;
                        }
                    }
                }
            }
            AssemblyCode.SelectedIndex = 0;
        }//Browse Button Click Event

        private void ParseButton_Click(object sender, EventArgs e)
        {
            int LineChoose = 0;
            String MemoryChoose = "";
            labelBox.Text = "";
            oppcodeBox.Text = "";
            addressBox.Text = "";
            IBox.Text = "";
            commentbox.Text = "";
           

            String[] commentarray = ((String)AssemblyCode.SelectedItem).Split('%');
            lineCounter.Text = "Line : " + Convert.ToString(Convert.ToInt16(AssemblyCode.SelectedIndex) + 1);
            commentarray[1].Trim();
            commentbox.Text = commentarray[1];
            if (commentarray[0].Contains(','))
            {
                String[] labelarray = commentarray[0].Split(',');
                labelBox.Text = labelarray[0].Trim();
                String[] restArray = labelarray[1].Trim().Split(' ');
                oppcodeBox.Text = restArray[0].Trim();
                if (restArray.Length >= 2)
                {
                    addressBox.Text = restArray[1].Trim();
                }
                if (restArray.Length >= 3)
                {
                    IBox.Text = restArray[2].Trim();
                }
            }
            else
            {
                labelBox.Text = "";
                String[] restArray = commentarray[0].Trim().Split(' ');
                oppcodeBox.Text = restArray[0].Trim();
                if (restArray.Length >= 2)
                {
                    addressBox.Text = restArray[1].Trim();
                }
                if (restArray.Length >= 3)
                {
                    IBox.Text = restArray[2].Trim();
                }
            }
            if (oppcodeBox.Text != "ORG" && oppcodeBox.Text != "HLT" && oppcodeBox.Text != "DEC" && oppcodeBox.Text != "HEX" && oppcodeBox.Text != "END")
            {
                fetchDecodeIndirect();
                int number_one;
                int number_two;
                String temp;
                switch (Decode.Substring(1, 1))
                {
                    case "1":
                        MO3.Text = "";
                        MO1.Text = "";
                        MO2.Text = "";
                        DR = DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value.ToString();
                        MO1.Text = "DR<-M[AR]";
                        SC++;
                        temp = "";
                        if (DR.Length == 4)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (AC.Substring(i, 1) == "0" && DR.Substring(i, 1) == "0")
                                {
                                    temp += "0";
                                }
                                else
                                {
                                    temp += "1";
                                }
                            }
                        }
                        AC = temp;
                        SC = 0;
                        MO2.Text = "AC<-AC V DR , SC<-0";
                        break;
                    case "2":
                        MO1.Text = "";
                        MO3.Text = "";
                        MO2.Text = "";
                        DR = DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value.ToString();
                        MO1.Text = "DR<-M[AR]";
                        SC++;
                        temp = "";
                        if (DR.Length == 4)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (AC.Substring(i, 1) == "1" && DR.Substring(i, 1) == "1")
                                {
                                    temp += "1";
                                }
                                else
                                {
                                    temp += "0";
                                }
                            }
                        }
                        AC = temp;
                        SC = 0;
                        MO2.Text = "AC<-AC ^ DR , SC<-0";
                        break;
                    case "3":
                        MO1.Text = "";
                        MO3.Text = "";
                        MO2.Text = "";
                        DR = DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value.ToString();
                        MO1.Text = "DR<-M[AR]";
                        SC++;
                        temp = "";
                        if (DR.Length == 4)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (AC.Substring(i, 1) == DR.Substring(i, 1))
                                {
                                    temp += "0";
                                }
                                else
                                {
                                    temp += "1";
                                }
                            }
                        }
                        AC = temp;
                        SC = 0;
                        MO2.Text = "AC<-AC⊕DR , SC<-0";
                        break;
                    case "4":
                        MO1.Text = "";
                        MO3.Text = "";
                        MO2.Text = "";
                        MO1.Text = "DR<-M[AR]";
                        DR = DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value.ToString();
                        SC++;
                        number_one = Convert.ToInt32(DR, 2);
                        number_two = Convert.ToInt32(AC, 2);
                        AC = Convert.ToString(number_one + number_two, 2);
                        SC = 0;
                        MO2.Text = "AC<-AC+DR , SC<-0";
                        break;
                    case "5":
                        MO1.Text = "";
                        MO3.Text = "";
                        MO2.Text = "";
                        MO1.Text = "DR<-M[AR]";
                        DR = DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value.ToString();
                        SC++;
                        AC = DR;
                        SC = 0;
                        MO2.Text = "AC<-DR , SC<-0";
                        break;
                    case "6":
                        MO1.Text = "";
                        MO3.Text = "";
                        MO2.Text = "";
                        MO1.Text = "M[AR]<-AR , SC<-0";
                        DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value = AC;
                        SC = 0;
                        break;
                    case "8":
                        MO3.Text = "";
                        MO1.Text = "";
                        MO2.Text = "";
                        MO1.Text = "PC<-AR , SC<-0";
                        PC = AR;
                        SC = 0;
                        break;
                    case "9":
                        MO3.Text = "";
                        MO1.Text = "";
                        MO2.Text = "";
                        MO1.Text = "M[AR]<-PC , AR<-AR+1";
                        DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value = PC;
                        number_one = Convert.ToInt32(AR, 2);
                        AR = Convert.ToString(number_one + 1, 2);
                        MO2.Text = "PC<-AR , SC<-0";
                        break;
                    case "15":
                        MO3.Text = "";
                        MO1.Text = "";
                        MO1.Text = "DR<-M[AR]";
                        MO2.Text = "";
                        DR = DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value.ToString();
                        SC++;
                        MO2.Text = "DR<-DR+1";
                        number_one = Convert.ToInt32(DR, 2);
                        DR = Convert.ToString(number_one + 1, 2);
                        SC++;
                        MO3.Text = "M[AR]<-DR , if(DR=0) then (PC<-PC+1) , SC<-0";
                        DataSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value = DR;
                        number_one = Convert.ToInt32(DR, 2);
                        if (number_one == 0)
                        {
                            number_one = Convert.ToInt32(PC, 2);
                            number_one++;
                            PC = Convert.ToString(number_one, 2);
                        }
                        SC = 0;
                        break;
                    default:
                        break;
                }
            }
            /*if (commentarray[0].Trim().Substring(0, 3) == "CMA")
            {
                string temp = commentarray[0].Trim().Substring(4, 1);
                for (int j = 0; j < LabelGrid.RowCount; j++)
                {
                    if (LabelGrid.Rows[j].Cells[0].Value.ToString() == temp)
                    {
                        DataSegment.Rows[Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Substring(1, 1))].Cells[1].Value = CMA(DataSegment.Rows[Convert.ToInt16(LabelGrid.Rows[j].Cells[1].Value.ToString().Substring(1, 1))].Cells[1].Value.ToString());
                        break;
                    }
                }
            }*/
            if ((AssemblyCode.Items.Count) - 1 == AssemblyCode.SelectedIndex)
            {
                AssemblyCode.SelectedIndex = -1;
            }
            AssemblyCode.SelectedIndex = AssemblyCode.SelectedIndex + 1;
            PCLabel.Text = PC;
            ARLabel.Text = AR;

        }/// Parse Button

        private string CMA(String binary)
        {
            string temp = "";
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    temp += "1";
                }
                else
                {
                    temp += "0";
                }
            }
            return temp;

        }
        private void fetchDecodeIndirect()
        {
            int number_one;
            AR = PC;
            IR = CodeSegment.Rows[Convert.ToInt16(AR,2)].Cells[1].Value.ToString();
            number_one = Convert.ToInt32(PC,2);
            number_one++;
            PC = Convert.ToString(number_one, 2);
            SC++;
            Decode = "D" + Convert.ToInt32(IR.Substring(1, 4), 2).ToString();
            AR = IR.Substring(5, 4);
            I = IR.Substring(0, 1);
            SC++;
            if (Decode.Substring(1,1)!="0" && I == "1")
            {
                AR = DataSegment.Rows[Convert.ToInt16(AR)].Cells[1].Value.ToString();
            }

        }

    }
}
