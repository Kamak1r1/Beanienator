using System.Windows.Forms;

namespace Bininator
{
    partial class BaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxHead = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxElastic = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxBini = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxLoop = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRow = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxBeforeWtoLoop = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBeforeWtoRow = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAfterWtoLoop = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAfterWtoRow = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.plotnostPosleWTOLoop = new System.Windows.Forms.MaskedTextBox();
            this.koefUsadkiLoop = new System.Windows.Forms.MaskedTextBox();
            this.plotnostPosleWTORow = new System.Windows.Forms.MaskedTextBox();
            this.koefUsadkiRow = new System.Windows.Forms.MaskedTextBox();
            this.nabrat = new System.Windows.Forms.MaskedTextBox();
            this.vazat = new System.Windows.Forms.MaskedTextBox();
            this.vazatEshe = new System.Windows.Forms.MaskedTextBox();
            this.vazatGladu = new System.Windows.Forms.MaskedTextBox();
            this.licevihLoop = new System.Windows.Forms.MaskedTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.ostanetsaLoop = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label41 = new System.Windows.Forms.Label();
            this.ParamButton = new System.Windows.Forms.Button();
            this.checkBoxElastik = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Обхват головы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Высота отворота (резинка 1х1 или 2х2)";
            // 
            // maskedTextBoxHead
            // 
            this.maskedTextBoxHead.BeepOnError = true;
            this.maskedTextBoxHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxHead.HidePromptOnLeave = true;
            this.maskedTextBoxHead.Location = new System.Drawing.Point(307, 114);
            this.maskedTextBoxHead.Name = "maskedTextBoxHead";
            this.maskedTextBoxHead.Size = new System.Drawing.Size(51, 23);
            this.maskedTextBoxHead.TabIndex = 3;
            this.maskedTextBoxHead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKey);
            // 
            // maskedTextBoxElastic
            // 
            this.maskedTextBoxElastic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxElastic.HidePromptOnLeave = true;
            this.maskedTextBoxElastic.Location = new System.Drawing.Point(307, 146);
            this.maskedTextBoxElastic.Name = "maskedTextBoxElastic";
            this.maskedTextBoxElastic.Size = new System.Drawing.Size(51, 23);
            this.maskedTextBoxElastic.TabIndex = 4;
            this.maskedTextBoxElastic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKey);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 62);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "БИНИНАТОР";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Keep calm and knit hat";
            // 
            // checkBoxBini
            // 
            this.checkBoxBini.AutoSize = true;
            this.checkBoxBini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBini.Location = new System.Drawing.Point(189, 219);
            this.checkBoxBini.Name = "checkBoxBini";
            this.checkBoxBini.Size = new System.Drawing.Size(60, 21);
            this.checkBoxBini.TabIndex = 6;
            this.checkBoxBini.Text = "Бини";
            this.toolTip1.SetToolTip(this.checkBoxBini, "Если флажок стоит, шапка будет с удлиненной макушкой.");
            this.checkBoxBini.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Образец:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Количество провязанных петель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Количество провязанных рядов";
            // 
            // maskedTextBoxLoop
            // 
            this.maskedTextBoxLoop.HidePromptOnLeave = true;
            this.maskedTextBoxLoop.Location = new System.Drawing.Point(307, 362);
            this.maskedTextBoxLoop.Name = "maskedTextBoxLoop";
            this.maskedTextBoxLoop.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxLoop.TabIndex = 10;
            this.maskedTextBoxLoop.ValidatingType = typeof(int);
            this.maskedTextBoxLoop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKey);
            // 
            // maskedTextBoxRow
            // 
            this.maskedTextBoxRow.HidePromptOnLeave = true;
            this.maskedTextBoxRow.Location = new System.Drawing.Point(307, 389);
            this.maskedTextBoxRow.Name = "maskedTextBoxRow";
            this.maskedTextBoxRow.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxRow.TabIndex = 11;
            this.maskedTextBoxRow.ValidatingType = typeof(int);
            this.maskedTextBoxRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKey);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Данные в сантимерах:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(40, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "До ВТО";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(40, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "После ВТО";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(130, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Петли(см)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(211, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ряды(см)";
            // 
            // maskedTextBoxBeforeWtoLoop
            // 
            this.maskedTextBoxBeforeWtoLoop.HidePromptOnLeave = true;
            this.maskedTextBoxBeforeWtoLoop.Location = new System.Drawing.Point(133, 491);
            this.maskedTextBoxBeforeWtoLoop.Name = "maskedTextBoxBeforeWtoLoop";
            this.maskedTextBoxBeforeWtoLoop.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxBeforeWtoLoop.TabIndex = 17;
            this.maskedTextBoxBeforeWtoLoop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKey);
            // 
            // maskedTextBoxBeforeWtoRow
            // 
            this.maskedTextBoxBeforeWtoRow.HidePromptOnLeave = true;
            this.maskedTextBoxBeforeWtoRow.Location = new System.Drawing.Point(214, 491);
            this.maskedTextBoxBeforeWtoRow.Name = "maskedTextBoxBeforeWtoRow";
            this.maskedTextBoxBeforeWtoRow.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxBeforeWtoRow.TabIndex = 18;
            this.maskedTextBoxBeforeWtoRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKey);
            // 
            // maskedTextBoxAfterWtoLoop
            // 
            this.maskedTextBoxAfterWtoLoop.HidePromptOnLeave = true;
            this.maskedTextBoxAfterWtoLoop.Location = new System.Drawing.Point(133, 527);
            this.maskedTextBoxAfterWtoLoop.Name = "maskedTextBoxAfterWtoLoop";
            this.maskedTextBoxAfterWtoLoop.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxAfterWtoLoop.TabIndex = 19;
            // 
            // maskedTextBoxAfterWtoRow
            // 
            this.maskedTextBoxAfterWtoRow.HidePromptOnLeave = true;
            this.maskedTextBoxAfterWtoRow.Location = new System.Drawing.Point(214, 527);
            this.maskedTextBoxAfterWtoRow.Name = "maskedTextBoxAfterWtoRow";
            this.maskedTextBoxAfterWtoRow.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxAfterWtoRow.TabIndex = 20;
            this.maskedTextBoxAfterWtoRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKey);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(33, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Ввод пользовательских данных:";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(97, 574);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(123, 52);
            this.calculateButton.TabIndex = 22;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(540, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Расчет плотности:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(370, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "1. Плотность после ВТО";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(370, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 17);
            this.label16.TabIndex = 25;
            this.label16.Text = "2. Коэффицент усадки";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(548, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "Петли";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(629, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Ряды";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(548, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "Расчет вязания:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(370, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 17);
            this.label20.TabIndex = 29;
            this.label20.Text = "1. Набрать";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(492, 206);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(179, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "+1 петель для замыкания";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(370, 230);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(536, 17);
            this.label22.TabIndex = 31;
            this.label22.Text = "2. Соединить вязание в круг, используя дополнительную петлю для замыкания";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(370, 255);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 17);
            this.label23.TabIndex = 32;
            this.label23.Text = "3. Вязать";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(492, 255);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(448, 17);
            this.label24.TabIndex = 33;
            this.label24.Text = "рядов резинки 1х1 или 2х2 (спицами на размер меньше основных)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(370, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(672, 17);
            this.label25.TabIndex = 34;
            this.label25.Text = "4. Выполнить \"подгиб\", вязать 2-3 ряда узором: * лицевую(ые) снимаем, изнаночные " +
    "провязываем *";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(370, 305);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 17);
            this.label26.TabIndex = 35;
            this.label26.Text = "5. Вязать еще";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(521, 305);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(185, 17);
            this.label27.TabIndex = 36;
            this.label27.Text = "рядов резинки 1х1 или 2х2";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(370, 330);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(277, 17);
            this.label28.TabIndex = 37;
            this.label28.Text = "6. Перейти на спицы основного размера";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(370, 355);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(121, 17);
            this.label29.TabIndex = 38;
            this.label29.Text = "7. Вязадь гладью";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(540, 355);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 17);
            this.label30.TabIndex = 39;
            this.label30.Text = "рядов";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(370, 380);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(303, 17);
            this.label31.TabIndex = 40;
            this.label31.Text = "8. Разделить вязание на 4 части маркерами";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(370, 405);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(274, 17);
            this.label32.TabIndex = 41;
            this.label32.Text = "9. Вязать: * 2 вместе с наклоном влево; ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(694, 405);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(117, 17);
            this.label33.TabIndex = 42;
            this.label33.Text = "лицевых петель;";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(646, 435);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(376, 17);
            this.label34.TabIndex = 43;
            this.label34.Text = "вязать лицевые петли до следующего маркера * 4 раза";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(370, 460);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(117, 17);
            this.label35.TabIndex = 44;
            this.label35.Text = "10. Все лицевые";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(370, 485);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(303, 17);
            this.label36.TabIndex = 45;
            this.label36.Text = "11. Повторять пункт 9-10 пока не останется";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(721, 485);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(54, 17);
            this.label37.TabIndex = 46;
            this.label37.Text = "петель";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(370, 510);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(568, 17);
            this.label38.TabIndex = 47;
            this.label38.Text = "12. Если оставшиеся петли стянуть сложно, провязать один ряд узором * 2 вместе *";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(370, 535);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(189, 17);
            this.label39.TabIndex = 48;
            this.label39.Text = "13. Стянуть петли макушки";
            // 
            // plotnostPosleWTOLoop
            // 
            this.plotnostPosleWTOLoop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plotnostPosleWTOLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plotnostPosleWTOLoop.Location = new System.Drawing.Point(547, 121);
            this.plotnostPosleWTOLoop.Name = "plotnostPosleWTOLoop";
            this.plotnostPosleWTOLoop.ReadOnly = true;
            this.plotnostPosleWTOLoop.Size = new System.Drawing.Size(51, 20);
            this.plotnostPosleWTOLoop.TabIndex = 49;
            // 
            // koefUsadkiLoop
            // 
            this.koefUsadkiLoop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.koefUsadkiLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.koefUsadkiLoop.Location = new System.Drawing.Point(547, 154);
            this.koefUsadkiLoop.Name = "koefUsadkiLoop";
            this.koefUsadkiLoop.ReadOnly = true;
            this.koefUsadkiLoop.ResetOnPrompt = false;
            this.koefUsadkiLoop.Size = new System.Drawing.Size(51, 20);
            this.koefUsadkiLoop.TabIndex = 50;
            // 
            // plotnostPosleWTORow
            // 
            this.plotnostPosleWTORow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plotnostPosleWTORow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plotnostPosleWTORow.Location = new System.Drawing.Point(625, 119);
            this.plotnostPosleWTORow.Name = "plotnostPosleWTORow";
            this.plotnostPosleWTORow.ReadOnly = true;
            this.plotnostPosleWTORow.ResetOnPrompt = false;
            this.plotnostPosleWTORow.Size = new System.Drawing.Size(51, 20);
            this.plotnostPosleWTORow.TabIndex = 51;
            // 
            // koefUsadkiRow
            // 
            this.koefUsadkiRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.koefUsadkiRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.koefUsadkiRow.Location = new System.Drawing.Point(625, 154);
            this.koefUsadkiRow.Name = "koefUsadkiRow";
            this.koefUsadkiRow.ReadOnly = true;
            this.koefUsadkiRow.ResetOnPrompt = false;
            this.koefUsadkiRow.Size = new System.Drawing.Size(51, 20);
            this.koefUsadkiRow.TabIndex = 52;
            // 
            // nabrat
            // 
            this.nabrat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nabrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nabrat.Location = new System.Drawing.Point(447, 205);
            this.nabrat.Name = "nabrat";
            this.nabrat.ReadOnly = true;
            this.nabrat.ResetOnPrompt = false;
            this.nabrat.Size = new System.Drawing.Size(39, 20);
            this.nabrat.TabIndex = 53;
            // 
            // vazat
            // 
            this.vazat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vazat.Location = new System.Drawing.Point(447, 254);
            this.vazat.Name = "vazat";
            this.vazat.ReadOnly = true;
            this.vazat.ResetOnPrompt = false;
            this.vazat.Size = new System.Drawing.Size(39, 20);
            this.vazat.TabIndex = 54;
            // 
            // vazatEshe
            // 
            this.vazatEshe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vazatEshe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vazatEshe.Location = new System.Drawing.Point(476, 304);
            this.vazatEshe.Name = "vazatEshe";
            this.vazatEshe.ReadOnly = true;
            this.vazatEshe.ResetOnPrompt = false;
            this.vazatEshe.Size = new System.Drawing.Size(39, 20);
            this.vazatEshe.TabIndex = 55;
            // 
            // vazatGladu
            // 
            this.vazatGladu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vazatGladu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vazatGladu.Location = new System.Drawing.Point(495, 354);
            this.vazatGladu.Name = "vazatGladu";
            this.vazatGladu.ReadOnly = true;
            this.vazatGladu.ResetOnPrompt = false;
            this.vazatGladu.Size = new System.Drawing.Size(39, 20);
            this.vazatGladu.TabIndex = 56;
            // 
            // licevihLoop
            // 
            this.licevihLoop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.licevihLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licevihLoop.Location = new System.Drawing.Point(649, 404);
            this.licevihLoop.Name = "licevihLoop";
            this.licevihLoop.ReadOnly = true;
            this.licevihLoop.ResetOnPrompt = false;
            this.licevihLoop.Size = new System.Drawing.Size(39, 20);
            this.licevihLoop.TabIndex = 57;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.Location = new System.Drawing.Point(450, 435);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(199, 17);
            this.label40.TabIndex = 59;
            this.label40.Text = "2 вместе с наклоном вправо;";
            // 
            // ostanetsaLoop
            // 
            this.ostanetsaLoop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ostanetsaLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ostanetsaLoop.Location = new System.Drawing.Point(676, 482);
            this.ostanetsaLoop.Name = "ostanetsaLoop";
            this.ostanetsaLoop.ReadOnly = true;
            this.ostanetsaLoop.ResetOnPrompt = false;
            this.ostanetsaLoop.Size = new System.Drawing.Size(39, 20);
            this.ostanetsaLoop.TabIndex = 60;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(7, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 21);
            this.radioButton2.TabIndex = 62;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "Прилегание -10% ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(7, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(142, 21);
            this.radioButton3.TabIndex = 63;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "Прилегание -15%";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(17, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 143);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(6, 103);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(142, 21);
            this.radioButton4.TabIndex = 64;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "3";
            this.radioButton4.Text = "Прилегание -20%";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 21);
            this.radioButton1.TabIndex = 61;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "Прилегание - 0%";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(186, 289);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(156, 23);
            this.buttonInfo.TabIndex = 66;
            this.buttonInfo.Text = "Информация по образцу";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(226, 574);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(119, 52);
            this.buttonReset.TabIndex = 67;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(854, 609);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 17);
            this.linkLabel1.TabIndex = 69;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@keepcalm_and_knit_on";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(676, 609);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(180, 17);
            this.label41.TabIndex = 70;
            this.label41.Text = "Мой аккаунт в Инстаграм:";
            // 
            // ParamButton
            // 
            this.ParamButton.Location = new System.Drawing.Point(186, 245);
            this.ParamButton.Name = "ParamButton";
            this.ParamButton.Size = new System.Drawing.Size(156, 36);
            this.ParamButton.TabIndex = 71;
            this.ParamButton.Text = "Рекомендации по параметрам";
            this.ParamButton.UseVisualStyleBackColor = true;
            this.ParamButton.Click += new System.EventHandler(this.ParamButton_Click);
            // 
            // checkBoxElastik
            // 
            this.checkBoxElastik.AutoSize = true;
            this.checkBoxElastik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxElastik.Location = new System.Drawing.Point(189, 192);
            this.checkBoxElastik.Name = "checkBoxElastik";
            this.checkBoxElastik.Size = new System.Drawing.Size(174, 21);
            this.checkBoxElastik.TabIndex = 72;
            this.checkBoxElastik.Text = "Резинка без отворота";
            this.checkBoxElastik.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 641);
            this.Controls.Add(this.checkBoxElastik);
            this.Controls.Add(this.ParamButton);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ostanetsaLoop);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.licevihLoop);
            this.Controls.Add(this.vazatGladu);
            this.Controls.Add(this.vazatEshe);
            this.Controls.Add(this.vazat);
            this.Controls.Add(this.nabrat);
            this.Controls.Add(this.koefUsadkiRow);
            this.Controls.Add(this.plotnostPosleWTORow);
            this.Controls.Add(this.koefUsadkiLoop);
            this.Controls.Add(this.plotnostPosleWTOLoop);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maskedTextBoxAfterWtoRow);
            this.Controls.Add(this.maskedTextBoxAfterWtoLoop);
            this.Controls.Add(this.maskedTextBoxBeforeWtoRow);
            this.Controls.Add(this.maskedTextBoxBeforeWtoLoop);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxRow);
            this.Controls.Add(this.maskedTextBoxLoop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxBini);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedTextBoxElastic);
            this.Controls.Add(this.maskedTextBoxHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1060, 680);
            this.MinimumSize = new System.Drawing.Size(1060, 680);
            this.Name = "BaseForm";
            this.Text = "Beanienator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MaskedTextBoxElastis(object sender, KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHead;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxElastic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxBini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLoop;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBeforeWtoLoop;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBeforeWtoRow;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAfterWtoLoop;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAfterWtoRow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.MaskedTextBox plotnostPosleWTOLoop;
        private System.Windows.Forms.MaskedTextBox koefUsadkiLoop;
        private System.Windows.Forms.MaskedTextBox plotnostPosleWTORow;
        private System.Windows.Forms.MaskedTextBox koefUsadkiRow;
        private System.Windows.Forms.MaskedTextBox nabrat;
        private System.Windows.Forms.MaskedTextBox vazat;
        private System.Windows.Forms.MaskedTextBox vazatEshe;
        private System.Windows.Forms.MaskedTextBox vazatGladu;
        private System.Windows.Forms.MaskedTextBox licevihLoop;
        private System.Windows.Forms.MaskedTextBox ostanetsaLoop;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ToolTip toolTip1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Button buttonInfo;
        private Button buttonReset;
        private LinkLabel linkLabel1;
        private RadioButton radioButton4;
        private Label label41;
        private Button ParamButton;
        private CheckBox checkBoxElastik;
    }
}

