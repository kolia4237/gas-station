﻿
namespace WindowsFormsApp19
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.toCount = new System.Windows.Forms.Button();
            this.HotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.textBoxRadioCount = new System.Windows.Forms.TextBox();
            this.textBoxRadioSum = new System.Windows.Forms.TextBox();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.groupBoxFuel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toPayGasStation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CokoColaCount = new System.Windows.Forms.TextBox();
            this.CokoColaPrice = new System.Windows.Forms.TextBox();
            this.FrenchFriesCount = new System.Windows.Forms.TextBox();
            this.FrenchFriesPrice = new System.Windows.Forms.TextBox();
            this.HamburgerCount = new System.Windows.Forms.TextBox();
            this.HamburgerPrice = new System.Windows.Forms.TextBox();
            this.HotDogCount = new System.Windows.Forms.TextBox();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.CokoColaCheckBox = new System.Windows.Forms.CheckBox();
            this.FrenchFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.HamburgerCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toPayCafe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toPayTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxFuel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 

            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена";
            // 

            this.toCount.ForeColor = System.Drawing.Color.Black;
            this.toCount.Location = new System.Drawing.Point(72, 24);
            this.toCount.Name = "toCount";
            this.toCount.Size = new System.Drawing.Size(148, 60);
            this.toCount.TabIndex = 1;
            this.toCount.Text = "Рассчитать";
            this.toCount.UseVisualStyleBackColor = true;
            // 

            this.HotDogCheckBox.AutoSize = true;
            this.HotDogCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HotDogCheckBox.Location = new System.Drawing.Point(6, 37);
            this.HotDogCheckBox.Name = "HotDogCheckBox";
            this.HotDogCheckBox.Size = new System.Drawing.Size(64, 17);
            this.HotDogCheckBox.TabIndex = 2;
            this.HotDogCheckBox.Text = "Хот-дог";
            this.HotDogCheckBox.UseVisualStyleBackColor = true;
            // 

            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.textBoxRadioCount);
            this.groupBox1.Controls.Add(this.textBoxRadioSum);
            this.groupBox1.Controls.Add(this.textBoxFuelPrice);
            this.groupBox1.Controls.Add(this.comboBoxFuel);
            this.groupBox1.Controls.Add(this.groupBoxFuel);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 

            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(196, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "грн.";
            // 

            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(196, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "л.";
            // 

            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена";
            // 

            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Топливо";

            // 

            this.groupBox6.Controls.Add(this.radioButtonSum);
            this.groupBox6.Controls.Add(this.radioButtonCount);
            this.groupBox6.Location = new System.Drawing.Point(6, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(103, 64);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 

            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.ForeColor = System.Drawing.Color.Black;
            this.radioButtonSum.Location = new System.Drawing.Point(9, 38);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.Text = "Сумма";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            // 

            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Checked = true;
            this.radioButtonCount.ForeColor = System.Drawing.Color.Black;
            this.radioButtonCount.Location = new System.Drawing.Point(9, 9);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCount.TabIndex = 0;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "Количество";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            // 

            this.textBoxRadioCount.Location = new System.Drawing.Point(119, 121);
            this.textBoxRadioCount.Name = "textBoxRadioCount";
            this.textBoxRadioCount.Size = new System.Drawing.Size(69, 20);
            this.textBoxRadioCount.TabIndex = 14;
            this.textBoxRadioCount.Text = "0,00";
            // 

            this.textBoxRadioSum.Location = new System.Drawing.Point(119, 157);
            this.textBoxRadioSum.Name = "textBoxRadioSum";
            this.textBoxRadioSum.ReadOnly = true;
            this.textBoxRadioSum.Size = new System.Drawing.Size(69, 20);
            this.textBoxRadioSum.TabIndex = 13;
            this.textBoxRadioSum.Text = "0,00";
            // 

            this.textBoxFuelPrice.Location = new System.Drawing.Point(72, 79);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.ReadOnly = true;
            this.textBoxFuelPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxFuelPrice.TabIndex = 11;
            // 

            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "АИ-92",
            "АИ-95",
            "АИ-98",
            "Газ",
            "Дизтопливо"});
            this.comboBoxFuel.Location = new System.Drawing.Point(72, 36);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFuel.TabIndex = 6;
            // 

            this.groupBoxFuel.Controls.Add(this.label5);
            this.groupBoxFuel.Controls.Add(this.toPayGasStation);
            this.groupBoxFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBoxFuel.Location = new System.Drawing.Point(6, 185);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Size = new System.Drawing.Size(217, 74);
            this.groupBoxFuel.TabIndex = 5;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "К оплате";
            // 

            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(149, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "грн.";
            // 

            this.toPayGasStation.Font = new System.Drawing.Font("", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayGasStation.ForeColor = System.Drawing.Color.Black;
            this.toPayGasStation.Location = new System.Drawing.Point(6, 16);
            this.toPayGasStation.Name = "toPayGasStation";
            this.toPayGasStation.Size = new System.Drawing.Size(136, 55);
            this.toPayGasStation.TabIndex = 11;
            this.toPayGasStation.Text = "0,00";
            this.toPayGasStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 

            this.groupBox2.Controls.Add(this.CokoColaCount);
            this.groupBox2.Controls.Add(this.CokoColaPrice);
            this.groupBox2.Controls.Add(this.FrenchFriesCount);
            this.groupBox2.Controls.Add(this.FrenchFriesPrice);
            this.groupBox2.Controls.Add(this.HamburgerCount);
            this.groupBox2.Controls.Add(this.HamburgerPrice);
            this.groupBox2.Controls.Add(this.HotDogCount);
            this.groupBox2.Controls.Add(this.HotDogPrice);
            this.groupBox2.Controls.Add(this.CokoColaCheckBox);
            this.groupBox2.Controls.Add(this.FrenchFriesCheckBox);
            this.groupBox2.Controls.Add(this.HamburgerCheckBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.HotDogCheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 265);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мини-Кафе";
            // 

            this.CokoColaCount.Location = new System.Drawing.Point(160, 127);
            this.CokoColaCount.Name = "CokoColaCount";
            this.CokoColaCount.ReadOnly = true;
            this.CokoColaCount.Size = new System.Drawing.Size(48, 20);
            this.CokoColaCount.TabIndex = 23;
            this.CokoColaCount.Text = "0,00";
            // 

            this.CokoColaPrice.Location = new System.Drawing.Point(106, 127);
            this.CokoColaPrice.Name = "CokoColaPrice";
            this.CokoColaPrice.ReadOnly = true;
            this.CokoColaPrice.Size = new System.Drawing.Size(48, 20);
            this.CokoColaPrice.TabIndex = 22;
            this.CokoColaPrice.Text = "18,00";
            // 

            this.FrenchFriesCount.Location = new System.Drawing.Point(160, 98);
            this.FrenchFriesCount.Name = "FrenchFriesCount";
            this.FrenchFriesCount.ReadOnly = true;
            this.FrenchFriesCount.Size = new System.Drawing.Size(48, 20);
            this.FrenchFriesCount.TabIndex = 21;
            this.FrenchFriesCount.Text = "0,00";
            // 

            this.FrenchFriesPrice.Location = new System.Drawing.Point(106, 98);
            this.FrenchFriesPrice.Name = "FrenchFriesPrice";
            this.FrenchFriesPrice.ReadOnly = true;
            this.FrenchFriesPrice.Size = new System.Drawing.Size(48, 20);
            this.FrenchFriesPrice.TabIndex = 20;
            this.FrenchFriesPrice.Text = "32,00";
            // 

            this.HamburgerCount.Location = new System.Drawing.Point(160, 67);
            this.HamburgerCount.Name = "HamburgerCount";
            this.HamburgerCount.ReadOnly = true;
            this.HamburgerCount.Size = new System.Drawing.Size(48, 20);
            this.HamburgerCount.TabIndex = 19;
            this.HamburgerCount.Text = "0,00";
            // 

            this.HamburgerPrice.Location = new System.Drawing.Point(106, 67);
            this.HamburgerPrice.Name = "HamburgerPrice";
            this.HamburgerPrice.ReadOnly = true;
            this.HamburgerPrice.Size = new System.Drawing.Size(48, 20);
            this.HamburgerPrice.TabIndex = 18;
            this.HamburgerPrice.Text = "20,00";
            // 

            this.HotDogCount.Location = new System.Drawing.Point(160, 37);
            this.HotDogCount.Name = "HotDogCount";
            this.HotDogCount.ReadOnly = true;
            this.HotDogCount.Size = new System.Drawing.Size(48, 20);
            this.HotDogCount.TabIndex = 17;
            this.HotDogCount.Text = "0,00";
            // 

            this.HotDogPrice.Location = new System.Drawing.Point(106, 37);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.ReadOnly = true;
            this.HotDogPrice.Size = new System.Drawing.Size(48, 20);
            this.HotDogPrice.TabIndex = 16;
            this.HotDogPrice.Text = "45,00";
            // 

            this.CokoColaCheckBox.AutoSize = true;
            this.CokoColaCheckBox.ForeColor = System.Drawing.Color.Black;
            this.CokoColaCheckBox.Location = new System.Drawing.Point(6, 127);
            this.CokoColaCheckBox.Name = "CokoColaCheckBox";
            this.CokoColaCheckBox.Size = new System.Drawing.Size(75, 17);
            this.CokoColaCheckBox.TabIndex = 10;
            this.CokoColaCheckBox.Text = "Coka-Cola";
            this.CokoColaCheckBox.UseVisualStyleBackColor = true;
            // 

            this.FrenchFriesCheckBox.AutoSize = true;
            this.FrenchFriesCheckBox.ForeColor = System.Drawing.Color.Black;
            this.FrenchFriesCheckBox.Location = new System.Drawing.Point(6, 98);
            this.FrenchFriesCheckBox.Name = "FrenchFriesCheckBox";
            this.FrenchFriesCheckBox.Size = new System.Drawing.Size(99, 17);
            this.FrenchFriesCheckBox.TabIndex = 9;
            this.FrenchFriesCheckBox.Text = "Картошка фри";
            this.FrenchFriesCheckBox.UseVisualStyleBackColor = true;
            // 

            this.HamburgerCheckBox.AutoSize = true;
            this.HamburgerCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HamburgerCheckBox.Location = new System.Drawing.Point(6, 67);
            this.HamburgerCheckBox.Name = "HamburgerCheckBox";
            this.HamburgerCheckBox.Size = new System.Drawing.Size(80, 17);
            this.HamburgerCheckBox.TabIndex = 8;
            this.HamburgerCheckBox.Text = "Гамбургер";
            this.HamburgerCheckBox.UseVisualStyleBackColor = true;
            // 

            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(147, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество";
            // 

            this.groupBox4.Controls.Add(this.toPayCafe);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(6, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 74);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате";
            // 

            this.toPayCafe.Font = new System.Drawing.Font("", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPayCafe.ForeColor = System.Drawing.Color.Black;
            this.toPayCafe.Location = new System.Drawing.Point(6, 16);
            this.toPayCafe.Name = "toPayCafe";
            this.toPayCafe.Size = new System.Drawing.Size(136, 55);
            this.toPayCafe.TabIndex = 13;
            this.toPayCafe.Text = "0,00";
            this.toPayCafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 

        }

        #endregion
    }
}

