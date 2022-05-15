namespace CreditCalc
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.gbGrafik = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butPriceClear = new System.Windows.Forms.Button();
            this.butPriceGo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceDiffer = new System.Windows.Forms.RadioButton();
            this.priceAnnuitet = new System.Windows.Forms.RadioButton();
            this.pricePeriodCombo = new System.Windows.Forms.ComboBox();
            this.pricePeriod = new System.Windows.Forms.NumericUpDown();
            this.priceProcent = new System.Windows.Forms.NumericUpDown();
            this.priceCreditSum = new System.Windows.Forms.TextBox();
            this.priceInitialType = new System.Windows.Forms.ComboBox();
            this.priceInitial = new System.Windows.Forms.NumericUpDown();
            this.pricePrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butSumClear = new System.Windows.Forms.Button();
            this.butSumGo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sumDiffer = new System.Windows.Forms.RadioButton();
            this.sumAnnuitet = new System.Windows.Forms.RadioButton();
            this.sumPeriodCombo = new System.Windows.Forms.ComboBox();
            this.sumPeriod = new System.Windows.Forms.NumericUpDown();
            this.sumProcent = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbItog = new System.Windows.Forms.GroupBox();
            this.butSaveAsCSV = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.itogPayment = new System.Windows.Forms.TextBox();
            this.itogOverpayment = new System.Windows.Forms.TextBox();
            this.itogSum = new System.Windows.Forms.TextBox();
            this.toolTipPaymentType = new System.Windows.Forms.ToolTip(this.components);
            this.colMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartProcent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumCreditSum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            this.gbGrafik.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePrice)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumProcent)).BeginInit();
            this.gbItog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumCreditSum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.AllowUserToAddRows = false;
            this.dgvGrafik.AllowUserToDeleteRows = false;
            this.dgvGrafik.AllowUserToResizeColumns = false;
            this.dgvGrafik.AllowUserToResizeRows = false;
            this.dgvGrafik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrafik.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMon,
            this.colSum,
            this.colPartCredit,
            this.colPartProcent,
            this.colBalance});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrafik.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvGrafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrafik.Location = new System.Drawing.Point(3, 16);
            this.dgvGrafik.MultiSelect = false;
            this.dgvGrafik.Name = "dgvGrafik";
            this.dgvGrafik.RowHeadersVisible = false;
            this.dgvGrafik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrafik.Size = new System.Drawing.Size(586, 352);
            this.dgvGrafik.TabIndex = 0;
            // 
            // gbGrafik
            // 
            this.gbGrafik.Controls.Add(this.dgvGrafik);
            this.gbGrafik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbGrafik.Location = new System.Drawing.Point(0, 231);
            this.gbGrafik.Name = "gbGrafik";
            this.gbGrafik.Size = new System.Drawing.Size(592, 371);
            this.gbGrafik.TabIndex = 1;
            this.gbGrafik.TabStop = false;
            this.gbGrafik.Text = "График платежей";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(352, 231);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.butPriceClear);
            this.tabPage1.Controls.Add(this.butPriceGo);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.priceDiffer);
            this.tabPage1.Controls.Add(this.priceAnnuitet);
            this.tabPage1.Controls.Add(this.pricePeriodCombo);
            this.tabPage1.Controls.Add(this.pricePeriod);
            this.tabPage1.Controls.Add(this.priceProcent);
            this.tabPage1.Controls.Add(this.priceCreditSum);
            this.tabPage1.Controls.Add(this.priceInitialType);
            this.tabPage1.Controls.Add(this.priceInitial);
            this.tabPage1.Controls.Add(this.pricePrice);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "По стоимости покупки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butPriceClear
            // 
            this.butPriceClear.Location = new System.Drawing.Point(11, 162);
            this.butPriceClear.Name = "butPriceClear";
            this.butPriceClear.Size = new System.Drawing.Size(152, 30);
            this.butPriceClear.TabIndex = 9;
            this.butPriceClear.Text = "Очистить расчеты";
            this.butPriceClear.UseVisualStyleBackColor = true;
            this.butPriceClear.Click += new System.EventHandler(this.butPriceClear_Click);
            // 
            // butPriceGo
            // 
            this.butPriceGo.Location = new System.Drawing.Point(169, 162);
            this.butPriceGo.Name = "butPriceGo";
            this.butPriceGo.Size = new System.Drawing.Size(159, 30);
            this.butPriceGo.TabIndex = 10;
            this.butPriceGo.Text = "Рассчитать стоимость";
            this.butPriceGo.UseVisualStyleBackColor = true;
            this.butPriceGo.Click += new System.EventHandler(this.butPriceGo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "% годовых";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "руб.";
            // 
            // priceDiffer
            // 
            this.priceDiffer.AutoSize = true;
            this.priceDiffer.Location = new System.Drawing.Point(186, 139);
            this.priceDiffer.Name = "priceDiffer";
            this.priceDiffer.Size = new System.Drawing.Size(142, 17);
            this.priceDiffer.TabIndex = 8;
            this.priceDiffer.TabStop = true;
            this.priceDiffer.Text = "Дифференцированный";
            this.toolTipPaymentType.SetToolTip(this.priceDiffer, "Вариант ежемесячного платежа\r\nпо кредиту, когда размер ежемесячного \r\nплатежа по " +
        "погашению кредита \r\nпостепенно уменьшается к концу \r\nпериода кредитования.\r\n");
            this.priceDiffer.UseVisualStyleBackColor = true;
            // 
            // priceAnnuitet
            // 
            this.priceAnnuitet.AutoSize = true;
            this.priceAnnuitet.Location = new System.Drawing.Point(89, 139);
            this.priceAnnuitet.Name = "priceAnnuitet";
            this.priceAnnuitet.Size = new System.Drawing.Size(91, 17);
            this.priceAnnuitet.TabIndex = 7;
            this.priceAnnuitet.TabStop = true;
            this.priceAnnuitet.Text = "Аннуитетный";
            this.toolTipPaymentType.SetToolTip(this.priceAnnuitet, "Вариант ежемесячного платежа \r\nпо кредиту, когда размер \r\nежемесячного платежа ос" +
        "таётся \r\nпостоянным на всём периоде \r\nкредитования.");
            this.priceAnnuitet.UseVisualStyleBackColor = true;
            // 
            // pricePeriodCombo
            // 
            this.pricePeriodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pricePeriodCombo.FormattingEnabled = true;
            this.pricePeriodCombo.Items.AddRange(new object[] {
            "лет",
            "мес."});
            this.pricePeriodCombo.Location = new System.Drawing.Point(206, 109);
            this.pricePeriodCombo.Name = "pricePeriodCombo";
            this.pricePeriodCombo.Size = new System.Drawing.Size(46, 21);
            this.pricePeriodCombo.TabIndex = 6;
            // 
            // pricePeriod
            // 
            this.pricePeriod.Location = new System.Drawing.Point(144, 110);
            this.pricePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pricePeriod.Name = "pricePeriod";
            this.pricePeriod.Size = new System.Drawing.Size(56, 20);
            this.pricePeriod.TabIndex = 5;
            this.pricePeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pricePeriod.Enter += new System.EventHandler(this.pricePeriod_Enter);
            // 
            // priceProcent
            // 
            this.priceProcent.DecimalPlaces = 2;
            this.priceProcent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceProcent.Location = new System.Drawing.Point(144, 84);
            this.priceProcent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceProcent.Name = "priceProcent";
            this.priceProcent.Size = new System.Drawing.Size(56, 20);
            this.priceProcent.TabIndex = 4;
            this.priceProcent.Enter += new System.EventHandler(this.priceProcent_Enter);
            // 
            // priceCreditSum
            // 
            this.priceCreditSum.Location = new System.Drawing.Point(144, 58);
            this.priceCreditSum.Name = "priceCreditSum";
            this.priceCreditSum.ReadOnly = true;
            this.priceCreditSum.Size = new System.Drawing.Size(108, 20);
            this.priceCreditSum.TabIndex = 3;
            // 
            // priceInitialType
            // 
            this.priceInitialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceInitialType.FormattingEnabled = true;
            this.priceInitialType.Items.AddRange(new object[] {
            "руб.",
            "%"});
            this.priceInitialType.Location = new System.Drawing.Point(258, 31);
            this.priceInitialType.Name = "priceInitialType";
            this.priceInitialType.Size = new System.Drawing.Size(49, 21);
            this.priceInitialType.TabIndex = 2;
            this.priceInitialType.SelectedIndexChanged += new System.EventHandler(this.priceInitialType_SelectedIndexChanged);
            // 
            // priceInitial
            // 
            this.priceInitial.Location = new System.Drawing.Point(144, 32);
            this.priceInitial.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.priceInitial.Name = "priceInitial";
            this.priceInitial.Size = new System.Drawing.Size(108, 20);
            this.priceInitial.TabIndex = 1;
            this.priceInitial.ThousandsSeparator = true;
            this.priceInitial.ValueChanged += new System.EventHandler(this.priceInitial_ValueChanged);
            this.priceInitial.Enter += new System.EventHandler(this.priceInitial_Enter);
            // 
            // pricePrice
            // 
            this.pricePrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pricePrice.Location = new System.Drawing.Point(144, 6);
            this.pricePrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.pricePrice.Name = "pricePrice";
            this.pricePrice.Size = new System.Drawing.Size(108, 20);
            this.pricePrice.TabIndex = 0;
            this.pricePrice.ThousandsSeparator = true;
            this.pricePrice.ValueChanged += new System.EventHandler(this.pricePrice_ValueChanged);
            this.pricePrice.Enter += new System.EventHandler(this.pricePrice_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вид платежа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Срок кредита:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Процентная ставка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма кредита:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Первоначальный взнос:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость покупки:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sumCreditSum);
            this.tabPage2.Controls.Add(this.butSumClear);
            this.tabPage2.Controls.Add(this.butSumGo);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.sumDiffer);
            this.tabPage2.Controls.Add(this.sumAnnuitet);
            this.tabPage2.Controls.Add(this.sumPeriodCombo);
            this.tabPage2.Controls.Add(this.sumPeriod);
            this.tabPage2.Controls.Add(this.sumProcent);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "По сумме кредита";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // butSumClear
            // 
            this.butSumClear.Location = new System.Drawing.Point(11, 162);
            this.butSumClear.Name = "butSumClear";
            this.butSumClear.Size = new System.Drawing.Size(152, 30);
            this.butSumClear.TabIndex = 6;
            this.butSumClear.Text = "Очистить расчеты";
            this.butSumClear.UseVisualStyleBackColor = true;
            this.butSumClear.Click += new System.EventHandler(this.butSumClear_Click);
            // 
            // butSumGo
            // 
            this.butSumGo.Location = new System.Drawing.Point(169, 162);
            this.butSumGo.Name = "butSumGo";
            this.butSumGo.Size = new System.Drawing.Size(159, 30);
            this.butSumGo.TabIndex = 7;
            this.butSumGo.Text = "Рассчитать стоимость";
            this.butSumGo.UseVisualStyleBackColor = true;
            this.butSumGo.Click += new System.EventHandler(this.butSumGo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "% годовых";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "руб.";
            // 
            // sumDiffer
            // 
            this.sumDiffer.AutoSize = true;
            this.sumDiffer.Location = new System.Drawing.Point(11, 130);
            this.sumDiffer.Name = "sumDiffer";
            this.sumDiffer.Size = new System.Drawing.Size(142, 17);
            this.sumDiffer.TabIndex = 5;
            this.sumDiffer.TabStop = true;
            this.sumDiffer.Text = "Дифференцированный";
            this.toolTipPaymentType.SetToolTip(this.sumDiffer, "Вариант ежемесячного платежа\r\nпо кредиту, когда размер ежемесячного \r\nплатежа по " +
        "погашению кредита \r\nпостепенно уменьшается к концу \r\nпериода кредитования.");
            this.sumDiffer.UseVisualStyleBackColor = true;
            // 
            // sumAnnuitet
            // 
            this.sumAnnuitet.AutoSize = true;
            this.sumAnnuitet.Location = new System.Drawing.Point(11, 107);
            this.sumAnnuitet.Name = "sumAnnuitet";
            this.sumAnnuitet.Size = new System.Drawing.Size(91, 17);
            this.sumAnnuitet.TabIndex = 4;
            this.sumAnnuitet.TabStop = true;
            this.sumAnnuitet.Text = "Аннуитетный";
            this.toolTipPaymentType.SetToolTip(this.sumAnnuitet, "Вариант ежемесячного платежа \r\nпо кредиту, когда размер \r\nежемесячного платежа ос" +
        "таётся \r\nпостоянным на всём периоде \r\nкредитования.");
            this.sumAnnuitet.UseVisualStyleBackColor = true;
            // 
            // sumPeriodCombo
            // 
            this.sumPeriodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sumPeriodCombo.FormattingEnabled = true;
            this.sumPeriodCombo.Items.AddRange(new object[] {
            "лет",
            "мес."});
            this.sumPeriodCombo.Location = new System.Drawing.Point(206, 57);
            this.sumPeriodCombo.Name = "sumPeriodCombo";
            this.sumPeriodCombo.Size = new System.Drawing.Size(46, 21);
            this.sumPeriodCombo.TabIndex = 3;
            // 
            // sumPeriod
            // 
            this.sumPeriod.Location = new System.Drawing.Point(144, 58);
            this.sumPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sumPeriod.Name = "sumPeriod";
            this.sumPeriod.Size = new System.Drawing.Size(56, 20);
            this.sumPeriod.TabIndex = 2;
            this.sumPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sumPeriod.Enter += new System.EventHandler(this.sumPeriod_Enter);
            // 
            // sumProcent
            // 
            this.sumProcent.DecimalPlaces = 2;
            this.sumProcent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sumProcent.Location = new System.Drawing.Point(144, 32);
            this.sumProcent.Name = "sumProcent";
            this.sumProcent.Size = new System.Drawing.Size(56, 20);
            this.sumProcent.TabIndex = 1;
            this.sumProcent.Enter += new System.EventHandler(this.sumProcent_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Вид платежа:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Срок кредита:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Процентная ставка:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Сумма кредита:";
            // 
            // gbItog
            // 
            this.gbItog.Controls.Add(this.butSaveAsCSV);
            this.gbItog.Controls.Add(this.label24);
            this.gbItog.Controls.Add(this.label23);
            this.gbItog.Controls.Add(this.label22);
            this.gbItog.Controls.Add(this.label21);
            this.gbItog.Controls.Add(this.label20);
            this.gbItog.Controls.Add(this.label19);
            this.gbItog.Controls.Add(this.itogPayment);
            this.gbItog.Controls.Add(this.itogOverpayment);
            this.gbItog.Controls.Add(this.itogSum);
            this.gbItog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbItog.Location = new System.Drawing.Point(352, 0);
            this.gbItog.Name = "gbItog";
            this.gbItog.Size = new System.Drawing.Size(240, 231);
            this.gbItog.TabIndex = 0;
            this.gbItog.TabStop = false;
            this.gbItog.Text = "Результат расчетов";
            // 
            // butSaveAsCSV
            // 
            this.butSaveAsCSV.Enabled = false;
            this.butSaveAsCSV.Image = ((System.Drawing.Image)(resources.GetObject("butSaveAsCSV.Image")));
            this.butSaveAsCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSaveAsCSV.Location = new System.Drawing.Point(33, 184);
            this.butSaveAsCSV.Name = "butSaveAsCSV";
            this.butSaveAsCSV.Size = new System.Drawing.Size(170, 30);
            this.butSaveAsCSV.TabIndex = 14;
            this.butSaveAsCSV.Text = "Экспорт расчетов в .CSV";
            this.butSaveAsCSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSaveAsCSV.UseVisualStyleBackColor = true;
            this.butSaveAsCSV.Click += new System.EventHandler(this.butSaveAsCSV_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(195, 148);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "руб.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(195, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "руб.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(195, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "руб.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Ежемесячный платеж:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Переплата по кредиту:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Итоговая стоимость:";
            // 
            // itogPayment
            // 
            this.itogPayment.Location = new System.Drawing.Point(19, 145);
            this.itogPayment.Name = "itogPayment";
            this.itogPayment.ReadOnly = true;
            this.itogPayment.Size = new System.Drawing.Size(170, 20);
            this.itogPayment.TabIndex = 13;
            // 
            // itogOverpayment
            // 
            this.itogOverpayment.Location = new System.Drawing.Point(19, 99);
            this.itogOverpayment.Name = "itogOverpayment";
            this.itogOverpayment.ReadOnly = true;
            this.itogOverpayment.Size = new System.Drawing.Size(170, 20);
            this.itogOverpayment.TabIndex = 12;
            // 
            // itogSum
            // 
            this.itogSum.Location = new System.Drawing.Point(19, 54);
            this.itogSum.Name = "itogSum";
            this.itogSum.ReadOnly = true;
            this.itogSum.Size = new System.Drawing.Size(170, 20);
            this.itogSum.TabIndex = 11;
            // 
            // toolTipPaymentType
            // 
            this.toolTipPaymentType.BackColor = System.Drawing.Color.AliceBlue;
            this.toolTipPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTipPaymentType.IsBalloon = true;
            // 
            // colMon
            // 
            this.colMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMon.HeaderText = "Месяц";
            this.colMon.Name = "colMon";
            this.colMon.Width = 65;
            // 
            // colSum
            // 
            this.colSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSum.HeaderText = "Сумма платежа";
            this.colSum.Name = "colSum";
            this.colSum.Width = 103;
            // 
            // colPartCredit
            // 
            this.colPartCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPartCredit.HeaderText = "Платеж по основному долгу, руб.";
            this.colPartCredit.Name = "colPartCredit";
            this.colPartCredit.Width = 165;
            // 
            // colPartProcent
            // 
            this.colPartProcent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPartProcent.HeaderText = "Платеж по процентам, руб.";
            this.colPartProcent.Name = "colPartProcent";
            this.colPartProcent.Width = 137;
            // 
            // colBalance
            // 
            this.colBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBalance.HeaderText = "Остаток основного долга, руб.";
            this.colBalance.Name = "colBalance";
            // 
            // sumCreditSum
            // 
            this.sumCreditSum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumCreditSum.Location = new System.Drawing.Point(144, 6);
            this.sumCreditSum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.sumCreditSum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumCreditSum.Name = "sumCreditSum";
            this.sumCreditSum.Size = new System.Drawing.Size(108, 20);
            this.sumCreditSum.TabIndex = 0;
            this.sumCreditSum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumCreditSum.Enter += new System.EventHandler(this.sumCreditSum_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 602);
            this.Controls.Add(this.gbItog);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.gbGrafik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Кредитный калькулятор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            this.gbGrafik.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePrice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumProcent)).EndInit();
            this.gbItog.ResumeLayout(false);
            this.gbItog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumCreditSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.GroupBox gbGrafik;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbItog;
        private System.Windows.Forms.Button butPriceClear;
        private System.Windows.Forms.Button butPriceGo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton priceDiffer;
        private System.Windows.Forms.RadioButton priceAnnuitet;
        private System.Windows.Forms.ComboBox pricePeriodCombo;
        private System.Windows.Forms.NumericUpDown pricePeriod;
        private System.Windows.Forms.NumericUpDown priceProcent;
        private System.Windows.Forms.TextBox priceCreditSum;
        private System.Windows.Forms.ComboBox priceInitialType;
        private System.Windows.Forms.NumericUpDown priceInitial;
        private System.Windows.Forms.NumericUpDown pricePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSumClear;
        private System.Windows.Forms.Button butSumGo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton sumDiffer;
        private System.Windows.Forms.RadioButton sumAnnuitet;
        private System.Windows.Forms.ComboBox sumPeriodCombo;
        private System.Windows.Forms.NumericUpDown sumPeriod;
        private System.Windows.Forms.NumericUpDown sumProcent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button butSaveAsCSV;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox itogPayment;
        private System.Windows.Forms.TextBox itogOverpayment;
        private System.Windows.Forms.TextBox itogSum;
        private System.Windows.Forms.ToolTip toolTipPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartProcent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.NumericUpDown sumCreditSum;
    }
}

