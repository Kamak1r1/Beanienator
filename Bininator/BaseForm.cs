using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bininator
{
    public partial class BaseForm : Form
    {
        private double head;
        private double elastik;
        private int loop;
        private int row;
        private double beforeRow;
        private double beforeLoop;
        private double afterRow;
        private double afterLoop;

        private double prileganie;
        private double dialLoops;

        private int checkedRB;

        public BaseForm()
        {
            InitializeComponent();

            //Получаем сохраненные данные полей
            maskedTextBoxHead.Text = Properties.Settings.Default.maskedTextBoxHead_Value;
            maskedTextBoxElastic.Text = Properties.Settings.Default.maskedTextBoxElastic_Value;
            maskedTextBoxLoop.Text = Properties.Settings.Default.maskedTextBoxLoop_Value;
            maskedTextBoxRow.Text = Properties.Settings.Default.maskedTextBoxRow_Value;
            maskedTextBoxBeforeWtoLoop.Text = Properties.Settings.Default.maskedTextBoxBeforeWtoLoop_Value;
            maskedTextBoxBeforeWtoRow.Text = Properties.Settings.Default.maskedTextBoxBeforeWtoRow_Value;
            maskedTextBoxAfterWtoRow.Text = Properties.Settings.Default.maskedTextBoxAfterWtoLoop_Value;
            maskedTextBoxAfterWtoLoop.Text = Properties.Settings.Default.maskedTextBoxAfterWtoRow_Value;
            checkBoxBini.Checked = Properties.Settings.Default.checkBoxBini;
            checkBoxElastik.Checked = Properties.Settings.Default.checkBoxElastik;
            checkedRB = Properties.Settings.Default.checkedRB;
            (new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 })[checkedRB].Checked = true;

        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (isInputMeasureValide())
            {

                //clear field
                plotnostPosleWTOLoop.Text = "";
                koefUsadkiLoop.Text = "";
                plotnostPosleWTORow.Text = "";
                koefUsadkiRow.Text = "";
                nabrat.Text = "";
                vazat.Text = "";
                vazatEshe.Text = "";
                vazatGladu.Text = "";
                licevihLoop.Text = "";
                ostanetsaLoop.Text = "";


                //take data
                head = double.Parse(maskedTextBoxHead.Text, CultureInfo.InvariantCulture);
                elastik = double.Parse(maskedTextBoxElastic.Text, CultureInfo.InvariantCulture);
                loop = int.Parse(maskedTextBoxLoop.Text, CultureInfo.InvariantCulture);
                row = int.Parse(maskedTextBoxRow.Text, CultureInfo.InvariantCulture);
                beforeLoop = double.Parse(maskedTextBoxBeforeWtoLoop.Text, CultureInfo.InvariantCulture);
                beforeRow = double.Parse(maskedTextBoxBeforeWtoRow.Text, CultureInfo.InvariantCulture);
                afterRow = double.Parse(maskedTextBoxAfterWtoRow.Text, CultureInfo.InvariantCulture);
                afterLoop = double.Parse(maskedTextBoxAfterWtoLoop.Text, CultureInfo.InvariantCulture);

                //Вычисляем прилегание
                for (int i = 0; i < groupBox1.Controls.Count; i++)
                {
                    if (((RadioButton)groupBox1.Controls[i]).Checked == true)
                    {
                        if (radioButton1.Checked == true)
                        {
                            prileganie = 1;
                            checkedRB = Convert.ToInt32(radioButton1.Tag);
                        }
                        else if (radioButton2.Checked == true)
                        {
                            prileganie = 0.9;
                            checkedRB = Convert.ToInt32(radioButton2.Tag);
                        }
                        else if (radioButton3.Checked == true)
                        {
                            prileganie = 0.85;
                            checkedRB = Convert.ToInt32(radioButton3.Tag);
                        }
                        else if (radioButton4.Checked == true)
                        {
                            prileganie = 0.8;
                            checkedRB = Convert.ToInt32(radioButton4.Tag);
                        }
                    }
                }

                //calculate
                //Расчет плотности и усадки
                //Плотность по петлям
                double densityByLoops = Math.Round(loop / afterLoop, 2, MidpointRounding.AwayFromZero);
                plotnostPosleWTOLoop.AppendText(Convert.ToString(densityByLoops));

                //Плотность по рядам
                double densityByRows = Math.Round(row / afterRow, 1, MidpointRounding.AwayFromZero);
                plotnostPosleWTORow.AppendText(Convert.ToString(densityByRows));

                //Усадка по петлям
                double shrinkageByLoops = Math.Round(afterLoop / beforeLoop, 2, MidpointRounding.AwayFromZero);
                koefUsadkiLoop.AppendText(Convert.ToString(shrinkageByLoops));

                //Усадка по рядам
                double shrinkageByRows = Math.Round(afterRow / beforeRow, 2, MidpointRounding.AwayFromZero);
                koefUsadkiRow.AppendText(Convert.ToString(shrinkageByRows));


                //Расчет шапки
                //5. Набор
                //5.1
                dialLoops = head * prileganie * densityByLoops;

                //5.2
                double connectInCircle = Math.Round(dialLoops / 4, 0, MidpointRounding.ToEven);

                //5.3
                double knittingRows = Math.Round(connectInCircle * 4, 0, MidpointRounding.ToEven);
                nabrat.AppendText(Convert.ToString(knittingRows));


                double rowElastic;
                double anyRowElastic;

                if (!checkBoxElastik.Checked)
                { 
                    //6
                     rowElastic = Math.Round(elastik * densityByRows, 1, MidpointRounding.ToEven);

                    //7
                     anyRowElastic = Math.Round(rowElastic / 2, 0);
                }
                else
                {
                     rowElastic = 0;
                     anyRowElastic = Math.Round(elastik * densityByRows, 1, MidpointRounding.ToEven);
                }

                vazat.AppendText(Convert.ToString((int)rowElastic));
                vazatEshe.AppendText(Convert.ToString((int)anyRowElastic));

                //8 Тулья
                //8.1
                double eightOne;

                if (head > 53)
                {
                    eightOne = Math.Round((head / 3) + 2, 0, MidpointRounding.ToEven);
                } 
                else
                {
                    eightOne = Math.Round((head / 3) + 1, 0, MidpointRounding.ToEven);
                }

                //8.2
                double eightTwo = Math.Round(eightOne * densityByRows, 0, MidpointRounding.ToEven);

                //8.3
                double cp;
                if ((knittingRows % 8) == 0)
                {
                    cp = 2;
                }
                else
                {
                    cp = 1;
                }

                licevihLoop.AppendText(Convert.ToString(cp));

                //8.4
                double answer;

                if (!checkBoxBini.Checked)
                {
                    answer = eightTwo - anyRowElastic - ((knittingRows / 4) - cp - 2);
                }
                else
                {
                    answer = eightTwo - anyRowElastic;
                }

                vazatGladu.AppendText(Convert.ToString((int)answer));

                //9
                //9.1
                double nineOne = (knittingRows / 4) - cp - 4;

                //9.2
                double nineTwo = (cp + 2) * 4;
                ostanetsaLoop.AppendText(Convert.ToString(nineTwo));

                //Сохраняем данные полей
                Properties.Settings.Default.maskedTextBoxHead_Value = maskedTextBoxHead.Text;
                Properties.Settings.Default.maskedTextBoxElastic_Value = maskedTextBoxElastic.Text;
                Properties.Settings.Default.maskedTextBoxLoop_Value = maskedTextBoxLoop.Text;
                Properties.Settings.Default.maskedTextBoxRow_Value = maskedTextBoxRow.Text;
                Properties.Settings.Default.maskedTextBoxBeforeWtoLoop_Value = maskedTextBoxBeforeWtoLoop.Text;
                Properties.Settings.Default.maskedTextBoxBeforeWtoRow_Value = maskedTextBoxBeforeWtoRow.Text;
                Properties.Settings.Default.maskedTextBoxAfterWtoLoop_Value = maskedTextBoxAfterWtoRow.Text;
                Properties.Settings.Default.maskedTextBoxAfterWtoRow_Value = maskedTextBoxAfterWtoLoop.Text;
                Properties.Settings.Default.checkBoxBini = checkBoxBini.Checked;
                Properties.Settings.Default.checkBoxElastik = checkBoxElastik.Checked;
                Properties.Settings.Default.checkedRB = checkedRB;
                
                Properties.Settings.Default.Save();
            }
        }

        private bool isInputMeasureValide()
        {
            string errorMessage = "";

            if (maskedTextBoxHead.Text == null || maskedTextBoxHead.Text.Length == 0)
            {
                errorMessage += "Не указан обхват головы!\n";
            }
            if (maskedTextBoxElastic.Text == null || maskedTextBoxElastic.Text.Length == 0)
            {
                errorMessage += "Не указана ширина резинки!\n";
            }
            if (maskedTextBoxLoop.Text == null || maskedTextBoxLoop.Text.Length == 0)
            {
                errorMessage += "Не указано количество провязанных рядов!\n";
            }
            if (maskedTextBoxRow.Text == null || maskedTextBoxRow.Text.Length == 0)
            {
                errorMessage += "Не указано количество провязанных петель!\n";
            }
            if (maskedTextBoxBeforeWtoLoop.Text == null || maskedTextBoxBeforeWtoLoop.Text.Length == 0)
            {
                errorMessage += "Не указаны петли до ВТО!\n";
            }
            if (maskedTextBoxBeforeWtoRow.Text == null || maskedTextBoxBeforeWtoRow.Text.Length == 0)
            {
                errorMessage += "Не указаны ряды до ВТО!\n";
            }
            if (maskedTextBoxAfterWtoLoop.Text == null || maskedTextBoxAfterWtoLoop.Text.Length == 0)
            {
                errorMessage += "Не указаны петли после ВТО!\n";
            }
            if (maskedTextBoxAfterWtoRow.Text == null || maskedTextBoxAfterWtoRow.Text.Length == 0)
            {
                errorMessage += "Не указаны ряды после ВТО!\n";
            }
            if (errorMessage.Length == 0)
            {
                return true;
            }
            else
            {
                // Show the error message
                DialogResult dialogResult = MessageBox.Show("Не все поля заполнены.", "Заполните все поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private bool AlreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void EnterKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if ((sender as MaskedTextBox).Text.Length == 0) e.Handled = true;

                // check if it's in the beginning of text not accept
                if ((sender as MaskedTextBox).SelectionStart == 0) e.Handled = true;

                // check if there is already exist a '.' , ','
                if (AlreadyExist((sender as MaskedTextBox).Text, ref sepratorChar)) e.Handled = true;

                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if ((sender as MaskedTextBox).SelectionStart != (sender as MaskedTextBox).Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = (sender as MaskedTextBox).Text.Substring((sender as MaskedTextBox).SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            maskedTextBoxHead.Text = "";
            maskedTextBoxElastic.Text = "";
            maskedTextBoxLoop.Text = "";
            maskedTextBoxRow.Text = "";
            maskedTextBoxBeforeWtoLoop.Text = "";
            maskedTextBoxBeforeWtoRow.Text = "";
            maskedTextBoxAfterWtoRow.Text = "";
            maskedTextBoxAfterWtoLoop.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBoxBini.Checked = false;
            checkBoxElastik.Checked = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://instagram.com/keepcalm_and_knit_on?igshid=wbnhiu79gd42");
        }

        private void ParamButton_Click(object sender, EventArgs e)
        {
            ParamWindow paramWindow = new ParamWindow();
            paramWindow.Show();
        }

    }
}