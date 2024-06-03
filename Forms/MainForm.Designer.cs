using System.Drawing;
using System.Windows.Forms;
using System;
using System.Drawing.Drawing2D;

namespace KenoGame
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
            this.cell1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cell2 = new System.Windows.Forms.Button();
            this.cell3 = new System.Windows.Forms.Button();
            this.cell4 = new System.Windows.Forms.Button();
            this.cell5 = new System.Windows.Forms.Button();
            this.cell6 = new System.Windows.Forms.Button();
            this.cell7 = new System.Windows.Forms.Button();
            this.cell8 = new System.Windows.Forms.Button();
            this.cell9 = new System.Windows.Forms.Button();
            this.cell10 = new System.Windows.Forms.Button();
            this.cell11 = new System.Windows.Forms.Button();
            this.cell12 = new System.Windows.Forms.Button();
            this.cell13 = new System.Windows.Forms.Button();
            this.cell14 = new System.Windows.Forms.Button();
            this.cell15 = new System.Windows.Forms.Button();
            this.cell16 = new System.Windows.Forms.Button();
            this.cell17 = new System.Windows.Forms.Button();
            this.cell18 = new System.Windows.Forms.Button();
            this.cell19 = new System.Windows.Forms.Button();
            this.cell20 = new System.Windows.Forms.Button();
            this.cell21 = new System.Windows.Forms.Button();
            this.cell22 = new System.Windows.Forms.Button();
            this.cell23 = new System.Windows.Forms.Button();
            this.cell24 = new System.Windows.Forms.Button();
            this.cell25 = new System.Windows.Forms.Button();
            this.cell26 = new System.Windows.Forms.Button();
            this.cell27 = new System.Windows.Forms.Button();
            this.cell28 = new System.Windows.Forms.Button();
            this.cell29 = new System.Windows.Forms.Button();
            this.cell30 = new System.Windows.Forms.Button();
            this.cell31 = new System.Windows.Forms.Button();
            this.cell32 = new System.Windows.Forms.Button();
            this.cell33 = new System.Windows.Forms.Button();
            this.cell34 = new System.Windows.Forms.Button();
            this.cell35 = new System.Windows.Forms.Button();
            this.cell36 = new System.Windows.Forms.Button();
            this.cell37 = new System.Windows.Forms.Button();
            this.cell38 = new System.Windows.Forms.Button();
            this.cell39 = new System.Windows.Forms.Button();
            this.cell40 = new System.Windows.Forms.Button();
            this.cell41 = new System.Windows.Forms.Button();
            this.cell42 = new System.Windows.Forms.Button();
            this.cell43 = new System.Windows.Forms.Button();
            this.cell44 = new System.Windows.Forms.Button();
            this.cell45 = new System.Windows.Forms.Button();
            this.cell46 = new System.Windows.Forms.Button();
            this.cell47 = new System.Windows.Forms.Button();
            this.cell48 = new System.Windows.Forms.Button();
            this.cell49 = new System.Windows.Forms.Button();
            this.cell50 = new System.Windows.Forms.Button();
            this.cell51 = new System.Windows.Forms.Button();
            this.cell52 = new System.Windows.Forms.Button();
            this.cell53 = new System.Windows.Forms.Button();
            this.cell54 = new System.Windows.Forms.Button();
            this.cell55 = new System.Windows.Forms.Button();
            this.cell56 = new System.Windows.Forms.Button();
            this.cell57 = new System.Windows.Forms.Button();
            this.cell58 = new System.Windows.Forms.Button();
            this.cell59 = new System.Windows.Forms.Button();
            this.cell60 = new System.Windows.Forms.Button();
            this.cell61 = new System.Windows.Forms.Button();
            this.cell62 = new System.Windows.Forms.Button();
            this.cell63 = new System.Windows.Forms.Button();
            this.cell64 = new System.Windows.Forms.Button();
            this.cell65 = new System.Windows.Forms.Button();
            this.cell66 = new System.Windows.Forms.Button();
            this.cell67 = new System.Windows.Forms.Button();
            this.cell68 = new System.Windows.Forms.Button();
            this.cell69 = new System.Windows.Forms.Button();
            this.cell70 = new System.Windows.Forms.Button();
            this.cell71 = new System.Windows.Forms.Button();
            this.cell72 = new System.Windows.Forms.Button();
            this.cell73 = new System.Windows.Forms.Button();
            this.cell74 = new System.Windows.Forms.Button();
            this.cell75 = new System.Windows.Forms.Button();
            this.cell76 = new System.Windows.Forms.Button();
            this.cell77 = new System.Windows.Forms.Button();
            this.cell78 = new System.Windows.Forms.Button();
            this.cell79 = new System.Windows.Forms.Button();
            this.cell80 = new System.Windows.Forms.Button();
            this.gameStartBtn = new System.Windows.Forms.Button();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.betLabel = new System.Windows.Forms.Label();
            this.attemptLabel = new System.Windows.Forms.Label();
            this.attemptNumeric = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.winningLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerBankLabel = new System.Windows.Forms.Label();
            this.playerBank = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cell1
            // 
            this.cell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell1.Location = new System.Drawing.Point(4, 4);
            this.cell1.Margin = new System.Windows.Forms.Padding(4);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(73, 65);
            this.cell1.TabIndex = 0;
            this.cell1.Text = "1";
            this.cell1.UseVisualStyleBackColor = true;
            this.cell1.Click += new System.EventHandler(this.Spot_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flowLayoutPanel.Controls.Add(this.cell1);
            this.flowLayoutPanel.Controls.Add(this.cell2);
            this.flowLayoutPanel.Controls.Add(this.cell3);
            this.flowLayoutPanel.Controls.Add(this.cell4);
            this.flowLayoutPanel.Controls.Add(this.cell5);
            this.flowLayoutPanel.Controls.Add(this.cell6);
            this.flowLayoutPanel.Controls.Add(this.cell7);
            this.flowLayoutPanel.Controls.Add(this.cell8);
            this.flowLayoutPanel.Controls.Add(this.cell9);
            this.flowLayoutPanel.Controls.Add(this.cell10);
            this.flowLayoutPanel.Controls.Add(this.cell11);
            this.flowLayoutPanel.Controls.Add(this.cell12);
            this.flowLayoutPanel.Controls.Add(this.cell13);
            this.flowLayoutPanel.Controls.Add(this.cell14);
            this.flowLayoutPanel.Controls.Add(this.cell15);
            this.flowLayoutPanel.Controls.Add(this.cell16);
            this.flowLayoutPanel.Controls.Add(this.cell17);
            this.flowLayoutPanel.Controls.Add(this.cell18);
            this.flowLayoutPanel.Controls.Add(this.cell19);
            this.flowLayoutPanel.Controls.Add(this.cell20);
            this.flowLayoutPanel.Controls.Add(this.cell21);
            this.flowLayoutPanel.Controls.Add(this.cell22);
            this.flowLayoutPanel.Controls.Add(this.cell23);
            this.flowLayoutPanel.Controls.Add(this.cell24);
            this.flowLayoutPanel.Controls.Add(this.cell25);
            this.flowLayoutPanel.Controls.Add(this.cell26);
            this.flowLayoutPanel.Controls.Add(this.cell27);
            this.flowLayoutPanel.Controls.Add(this.cell28);
            this.flowLayoutPanel.Controls.Add(this.cell29);
            this.flowLayoutPanel.Controls.Add(this.cell30);
            this.flowLayoutPanel.Controls.Add(this.cell31);
            this.flowLayoutPanel.Controls.Add(this.cell32);
            this.flowLayoutPanel.Controls.Add(this.cell33);
            this.flowLayoutPanel.Controls.Add(this.cell34);
            this.flowLayoutPanel.Controls.Add(this.cell35);
            this.flowLayoutPanel.Controls.Add(this.cell36);
            this.flowLayoutPanel.Controls.Add(this.cell37);
            this.flowLayoutPanel.Controls.Add(this.cell38);
            this.flowLayoutPanel.Controls.Add(this.cell39);
            this.flowLayoutPanel.Controls.Add(this.cell40);
            this.flowLayoutPanel.Controls.Add(this.cell41);
            this.flowLayoutPanel.Controls.Add(this.cell42);
            this.flowLayoutPanel.Controls.Add(this.cell43);
            this.flowLayoutPanel.Controls.Add(this.cell44);
            this.flowLayoutPanel.Controls.Add(this.cell45);
            this.flowLayoutPanel.Controls.Add(this.cell46);
            this.flowLayoutPanel.Controls.Add(this.cell47);
            this.flowLayoutPanel.Controls.Add(this.cell48);
            this.flowLayoutPanel.Controls.Add(this.cell49);
            this.flowLayoutPanel.Controls.Add(this.cell50);
            this.flowLayoutPanel.Controls.Add(this.cell51);
            this.flowLayoutPanel.Controls.Add(this.cell52);
            this.flowLayoutPanel.Controls.Add(this.cell53);
            this.flowLayoutPanel.Controls.Add(this.cell54);
            this.flowLayoutPanel.Controls.Add(this.cell55);
            this.flowLayoutPanel.Controls.Add(this.cell56);
            this.flowLayoutPanel.Controls.Add(this.cell57);
            this.flowLayoutPanel.Controls.Add(this.cell58);
            this.flowLayoutPanel.Controls.Add(this.cell59);
            this.flowLayoutPanel.Controls.Add(this.cell60);
            this.flowLayoutPanel.Controls.Add(this.cell61);
            this.flowLayoutPanel.Controls.Add(this.cell62);
            this.flowLayoutPanel.Controls.Add(this.cell63);
            this.flowLayoutPanel.Controls.Add(this.cell64);
            this.flowLayoutPanel.Controls.Add(this.cell65);
            this.flowLayoutPanel.Controls.Add(this.cell66);
            this.flowLayoutPanel.Controls.Add(this.cell67);
            this.flowLayoutPanel.Controls.Add(this.cell68);
            this.flowLayoutPanel.Controls.Add(this.cell69);
            this.flowLayoutPanel.Controls.Add(this.cell70);
            this.flowLayoutPanel.Controls.Add(this.cell71);
            this.flowLayoutPanel.Controls.Add(this.cell72);
            this.flowLayoutPanel.Controls.Add(this.cell73);
            this.flowLayoutPanel.Controls.Add(this.cell74);
            this.flowLayoutPanel.Controls.Add(this.cell75);
            this.flowLayoutPanel.Controls.Add(this.cell76);
            this.flowLayoutPanel.Controls.Add(this.cell77);
            this.flowLayoutPanel.Controls.Add(this.cell78);
            this.flowLayoutPanel.Controls.Add(this.cell79);
            this.flowLayoutPanel.Controls.Add(this.cell80);
            this.flowLayoutPanel.Location = new System.Drawing.Point(306, 58);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(817, 581);
            this.flowLayoutPanel.TabIndex = 1;
            this.flowLayoutPanel.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell2
            // 
            this.cell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell2.Location = new System.Drawing.Point(85, 4);
            this.cell2.Margin = new System.Windows.Forms.Padding(4);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(73, 65);
            this.cell2.TabIndex = 1;
            this.cell2.Text = "2";
            this.cell2.UseVisualStyleBackColor = true;
            this.cell2.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell3
            // 
            this.cell3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell3.Location = new System.Drawing.Point(166, 4);
            this.cell3.Margin = new System.Windows.Forms.Padding(4);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(73, 65);
            this.cell3.TabIndex = 2;
            this.cell3.Text = "3";
            this.cell3.UseVisualStyleBackColor = true;
            this.cell3.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell4
            // 
            this.cell4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell4.Location = new System.Drawing.Point(247, 4);
            this.cell4.Margin = new System.Windows.Forms.Padding(4);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(73, 65);
            this.cell4.TabIndex = 3;
            this.cell4.Text = "4";
            this.cell4.UseVisualStyleBackColor = true;
            this.cell4.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell5
            // 
            this.cell5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell5.Location = new System.Drawing.Point(328, 4);
            this.cell5.Margin = new System.Windows.Forms.Padding(4);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(73, 65);
            this.cell5.TabIndex = 4;
            this.cell5.Text = "5";
            this.cell5.UseVisualStyleBackColor = true;
            this.cell5.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell6
            // 
            this.cell6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell6.Location = new System.Drawing.Point(409, 4);
            this.cell6.Margin = new System.Windows.Forms.Padding(4);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(73, 65);
            this.cell6.TabIndex = 5;
            this.cell6.Text = "6";
            this.cell6.UseVisualStyleBackColor = true;
            this.cell6.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell7
            // 
            this.cell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell7.Location = new System.Drawing.Point(490, 4);
            this.cell7.Margin = new System.Windows.Forms.Padding(4);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(73, 65);
            this.cell7.TabIndex = 6;
            this.cell7.Text = "7";
            this.cell7.UseVisualStyleBackColor = true;
            this.cell7.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell8
            // 
            this.cell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell8.Location = new System.Drawing.Point(571, 4);
            this.cell8.Margin = new System.Windows.Forms.Padding(4);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(73, 65);
            this.cell8.TabIndex = 7;
            this.cell8.Text = "8";
            this.cell8.UseVisualStyleBackColor = true;
            this.cell8.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell9
            // 
            this.cell9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell9.Location = new System.Drawing.Point(652, 4);
            this.cell9.Margin = new System.Windows.Forms.Padding(4);
            this.cell9.Name = "cell9";
            this.cell9.Size = new System.Drawing.Size(73, 65);
            this.cell9.TabIndex = 8;
            this.cell9.Text = "9";
            this.cell9.UseVisualStyleBackColor = true;
            this.cell9.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell10
            // 
            this.cell10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell10.Location = new System.Drawing.Point(733, 4);
            this.cell10.Margin = new System.Windows.Forms.Padding(4);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(73, 65);
            this.cell10.TabIndex = 9;
            this.cell10.Text = "10";
            this.cell10.UseVisualStyleBackColor = true;
            this.cell10.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell11
            // 
            this.cell11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell11.Location = new System.Drawing.Point(4, 77);
            this.cell11.Margin = new System.Windows.Forms.Padding(4);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(73, 65);
            this.cell11.TabIndex = 10;
            this.cell11.Text = "11";
            this.cell11.UseVisualStyleBackColor = true;
            this.cell11.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell12
            // 
            this.cell12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell12.Location = new System.Drawing.Point(85, 77);
            this.cell12.Margin = new System.Windows.Forms.Padding(4);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(73, 65);
            this.cell12.TabIndex = 11;
            this.cell12.Text = "12";
            this.cell12.UseVisualStyleBackColor = true;
            this.cell12.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell13
            // 
            this.cell13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell13.Location = new System.Drawing.Point(166, 77);
            this.cell13.Margin = new System.Windows.Forms.Padding(4);
            this.cell13.Name = "cell13";
            this.cell13.Size = new System.Drawing.Size(73, 65);
            this.cell13.TabIndex = 12;
            this.cell13.Text = "13";
            this.cell13.UseVisualStyleBackColor = true;
            this.cell13.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell14
            // 
            this.cell14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell14.Location = new System.Drawing.Point(247, 77);
            this.cell14.Margin = new System.Windows.Forms.Padding(4);
            this.cell14.Name = "cell14";
            this.cell14.Size = new System.Drawing.Size(73, 65);
            this.cell14.TabIndex = 13;
            this.cell14.Text = "14";
            this.cell14.UseVisualStyleBackColor = true;
            this.cell14.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell15
            // 
            this.cell15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell15.Location = new System.Drawing.Point(328, 77);
            this.cell15.Margin = new System.Windows.Forms.Padding(4);
            this.cell15.Name = "cell15";
            this.cell15.Size = new System.Drawing.Size(73, 65);
            this.cell15.TabIndex = 14;
            this.cell15.Text = "15";
            this.cell15.UseVisualStyleBackColor = true;
            this.cell15.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell16
            // 
            this.cell16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell16.Location = new System.Drawing.Point(409, 77);
            this.cell16.Margin = new System.Windows.Forms.Padding(4);
            this.cell16.Name = "cell16";
            this.cell16.Size = new System.Drawing.Size(73, 65);
            this.cell16.TabIndex = 15;
            this.cell16.Text = "16";
            this.cell16.UseVisualStyleBackColor = true;
            this.cell16.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell17
            // 
            this.cell17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell17.Location = new System.Drawing.Point(490, 77);
            this.cell17.Margin = new System.Windows.Forms.Padding(4);
            this.cell17.Name = "cell17";
            this.cell17.Size = new System.Drawing.Size(73, 65);
            this.cell17.TabIndex = 16;
            this.cell17.Text = "17";
            this.cell17.UseVisualStyleBackColor = true;
            this.cell17.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell18
            // 
            this.cell18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell18.Location = new System.Drawing.Point(571, 77);
            this.cell18.Margin = new System.Windows.Forms.Padding(4);
            this.cell18.Name = "cell18";
            this.cell18.Size = new System.Drawing.Size(73, 65);
            this.cell18.TabIndex = 17;
            this.cell18.Text = "18";
            this.cell18.UseVisualStyleBackColor = true;
            this.cell18.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell19
            // 
            this.cell19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell19.Location = new System.Drawing.Point(652, 77);
            this.cell19.Margin = new System.Windows.Forms.Padding(4);
            this.cell19.Name = "cell19";
            this.cell19.Size = new System.Drawing.Size(73, 65);
            this.cell19.TabIndex = 18;
            this.cell19.Text = "19";
            this.cell19.UseVisualStyleBackColor = true;
            this.cell19.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell20
            // 
            this.cell20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell20.Location = new System.Drawing.Point(733, 77);
            this.cell20.Margin = new System.Windows.Forms.Padding(4);
            this.cell20.Name = "cell20";
            this.cell20.Size = new System.Drawing.Size(73, 65);
            this.cell20.TabIndex = 19;
            this.cell20.Text = "20";
            this.cell20.UseVisualStyleBackColor = true;
            this.cell20.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell21
            // 
            this.cell21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell21.Location = new System.Drawing.Point(4, 150);
            this.cell21.Margin = new System.Windows.Forms.Padding(4);
            this.cell21.Name = "cell21";
            this.cell21.Size = new System.Drawing.Size(73, 65);
            this.cell21.TabIndex = 20;
            this.cell21.Text = "21";
            this.cell21.UseVisualStyleBackColor = true;
            this.cell21.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell22
            // 
            this.cell22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell22.Location = new System.Drawing.Point(85, 150);
            this.cell22.Margin = new System.Windows.Forms.Padding(4);
            this.cell22.Name = "cell22";
            this.cell22.Size = new System.Drawing.Size(73, 65);
            this.cell22.TabIndex = 21;
            this.cell22.Text = "22";
            this.cell22.UseVisualStyleBackColor = true;
            this.cell22.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell23
            // 
            this.cell23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell23.Location = new System.Drawing.Point(166, 150);
            this.cell23.Margin = new System.Windows.Forms.Padding(4);
            this.cell23.Name = "cell23";
            this.cell23.Size = new System.Drawing.Size(73, 65);
            this.cell23.TabIndex = 22;
            this.cell23.Text = "23";
            this.cell23.UseVisualStyleBackColor = true;
            this.cell23.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell24
            // 
            this.cell24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell24.Location = new System.Drawing.Point(247, 150);
            this.cell24.Margin = new System.Windows.Forms.Padding(4);
            this.cell24.Name = "cell24";
            this.cell24.Size = new System.Drawing.Size(73, 65);
            this.cell24.TabIndex = 23;
            this.cell24.Text = "24";
            this.cell24.UseVisualStyleBackColor = true;
            this.cell24.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell25
            // 
            this.cell25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell25.Location = new System.Drawing.Point(328, 150);
            this.cell25.Margin = new System.Windows.Forms.Padding(4);
            this.cell25.Name = "cell25";
            this.cell25.Size = new System.Drawing.Size(73, 65);
            this.cell25.TabIndex = 24;
            this.cell25.Text = "25";
            this.cell25.UseVisualStyleBackColor = true;
            this.cell25.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell26
            // 
            this.cell26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell26.Location = new System.Drawing.Point(409, 150);
            this.cell26.Margin = new System.Windows.Forms.Padding(4);
            this.cell26.Name = "cell26";
            this.cell26.Size = new System.Drawing.Size(73, 65);
            this.cell26.TabIndex = 25;
            this.cell26.Text = "26";
            this.cell26.UseVisualStyleBackColor = true;
            this.cell26.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell27
            // 
            this.cell27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell27.Location = new System.Drawing.Point(490, 150);
            this.cell27.Margin = new System.Windows.Forms.Padding(4);
            this.cell27.Name = "cell27";
            this.cell27.Size = new System.Drawing.Size(73, 65);
            this.cell27.TabIndex = 26;
            this.cell27.Text = "27";
            this.cell27.UseVisualStyleBackColor = true;
            this.cell27.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell28
            // 
            this.cell28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell28.Location = new System.Drawing.Point(571, 150);
            this.cell28.Margin = new System.Windows.Forms.Padding(4);
            this.cell28.Name = "cell28";
            this.cell28.Size = new System.Drawing.Size(73, 65);
            this.cell28.TabIndex = 27;
            this.cell28.Text = "28";
            this.cell28.UseVisualStyleBackColor = true;
            this.cell28.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell29
            // 
            this.cell29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell29.Location = new System.Drawing.Point(652, 150);
            this.cell29.Margin = new System.Windows.Forms.Padding(4);
            this.cell29.Name = "cell29";
            this.cell29.Size = new System.Drawing.Size(73, 65);
            this.cell29.TabIndex = 28;
            this.cell29.Text = "29";
            this.cell29.UseVisualStyleBackColor = true;
            this.cell29.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell30
            // 
            this.cell30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell30.Location = new System.Drawing.Point(733, 150);
            this.cell30.Margin = new System.Windows.Forms.Padding(4);
            this.cell30.Name = "cell30";
            this.cell30.Size = new System.Drawing.Size(73, 65);
            this.cell30.TabIndex = 29;
            this.cell30.Text = "30";
            this.cell30.UseVisualStyleBackColor = true;
            this.cell30.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell31
            // 
            this.cell31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell31.Location = new System.Drawing.Point(4, 223);
            this.cell31.Margin = new System.Windows.Forms.Padding(4);
            this.cell31.Name = "cell31";
            this.cell31.Size = new System.Drawing.Size(73, 65);
            this.cell31.TabIndex = 30;
            this.cell31.Text = "31";
            this.cell31.UseVisualStyleBackColor = true;
            this.cell31.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell32
            // 
            this.cell32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell32.Location = new System.Drawing.Point(85, 223);
            this.cell32.Margin = new System.Windows.Forms.Padding(4);
            this.cell32.Name = "cell32";
            this.cell32.Size = new System.Drawing.Size(73, 65);
            this.cell32.TabIndex = 31;
            this.cell32.Text = "32";
            this.cell32.UseVisualStyleBackColor = true;
            this.cell32.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell33
            // 
            this.cell33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell33.Location = new System.Drawing.Point(166, 223);
            this.cell33.Margin = new System.Windows.Forms.Padding(4);
            this.cell33.Name = "cell33";
            this.cell33.Size = new System.Drawing.Size(73, 65);
            this.cell33.TabIndex = 32;
            this.cell33.Text = "33";
            this.cell33.UseVisualStyleBackColor = true;
            this.cell33.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell34
            // 
            this.cell34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell34.Location = new System.Drawing.Point(247, 223);
            this.cell34.Margin = new System.Windows.Forms.Padding(4);
            this.cell34.Name = "cell34";
            this.cell34.Size = new System.Drawing.Size(73, 65);
            this.cell34.TabIndex = 33;
            this.cell34.Text = "34";
            this.cell34.UseVisualStyleBackColor = true;
            this.cell34.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell35
            // 
            this.cell35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell35.Location = new System.Drawing.Point(328, 223);
            this.cell35.Margin = new System.Windows.Forms.Padding(4);
            this.cell35.Name = "cell35";
            this.cell35.Size = new System.Drawing.Size(73, 65);
            this.cell35.TabIndex = 34;
            this.cell35.Text = "35";
            this.cell35.UseVisualStyleBackColor = true;
            this.cell35.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell36
            // 
            this.cell36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell36.Location = new System.Drawing.Point(409, 223);
            this.cell36.Margin = new System.Windows.Forms.Padding(4);
            this.cell36.Name = "cell36";
            this.cell36.Size = new System.Drawing.Size(73, 65);
            this.cell36.TabIndex = 35;
            this.cell36.Text = "36";
            this.cell36.UseVisualStyleBackColor = true;
            this.cell36.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell37
            // 
            this.cell37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell37.Location = new System.Drawing.Point(490, 223);
            this.cell37.Margin = new System.Windows.Forms.Padding(4);
            this.cell37.Name = "cell37";
            this.cell37.Size = new System.Drawing.Size(73, 65);
            this.cell37.TabIndex = 36;
            this.cell37.Text = "37";
            this.cell37.UseVisualStyleBackColor = true;
            this.cell37.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell38
            // 
            this.cell38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell38.Location = new System.Drawing.Point(571, 223);
            this.cell38.Margin = new System.Windows.Forms.Padding(4);
            this.cell38.Name = "cell38";
            this.cell38.Size = new System.Drawing.Size(73, 65);
            this.cell38.TabIndex = 37;
            this.cell38.Text = "38";
            this.cell38.UseVisualStyleBackColor = true;
            this.cell38.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell39
            // 
            this.cell39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell39.Location = new System.Drawing.Point(652, 223);
            this.cell39.Margin = new System.Windows.Forms.Padding(4);
            this.cell39.Name = "cell39";
            this.cell39.Size = new System.Drawing.Size(73, 65);
            this.cell39.TabIndex = 38;
            this.cell39.Text = "39";
            this.cell39.UseVisualStyleBackColor = true;
            this.cell39.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell40
            // 
            this.cell40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell40.Location = new System.Drawing.Point(733, 223);
            this.cell40.Margin = new System.Windows.Forms.Padding(4);
            this.cell40.Name = "cell40";
            this.cell40.Size = new System.Drawing.Size(73, 65);
            this.cell40.TabIndex = 39;
            this.cell40.Text = "40";
            this.cell40.UseVisualStyleBackColor = true;
            this.cell40.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell41
            // 
            this.cell41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell41.Location = new System.Drawing.Point(4, 296);
            this.cell41.Margin = new System.Windows.Forms.Padding(4);
            this.cell41.Name = "cell41";
            this.cell41.Size = new System.Drawing.Size(73, 65);
            this.cell41.TabIndex = 40;
            this.cell41.Text = "41";
            this.cell41.UseVisualStyleBackColor = true;
            this.cell41.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell42
            // 
            this.cell42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell42.Location = new System.Drawing.Point(85, 296);
            this.cell42.Margin = new System.Windows.Forms.Padding(4);
            this.cell42.Name = "cell42";
            this.cell42.Size = new System.Drawing.Size(73, 65);
            this.cell42.TabIndex = 41;
            this.cell42.Text = "42";
            this.cell42.UseVisualStyleBackColor = true;
            this.cell42.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell43
            // 
            this.cell43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell43.Location = new System.Drawing.Point(166, 296);
            this.cell43.Margin = new System.Windows.Forms.Padding(4);
            this.cell43.Name = "cell43";
            this.cell43.Size = new System.Drawing.Size(73, 65);
            this.cell43.TabIndex = 42;
            this.cell43.Text = "43";
            this.cell43.UseVisualStyleBackColor = true;
            this.cell43.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell44
            // 
            this.cell44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell44.Location = new System.Drawing.Point(247, 296);
            this.cell44.Margin = new System.Windows.Forms.Padding(4);
            this.cell44.Name = "cell44";
            this.cell44.Size = new System.Drawing.Size(73, 65);
            this.cell44.TabIndex = 43;
            this.cell44.Text = "44";
            this.cell44.UseVisualStyleBackColor = true;
            this.cell44.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell45
            // 
            this.cell45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell45.Location = new System.Drawing.Point(328, 296);
            this.cell45.Margin = new System.Windows.Forms.Padding(4);
            this.cell45.Name = "cell45";
            this.cell45.Size = new System.Drawing.Size(73, 65);
            this.cell45.TabIndex = 44;
            this.cell45.Text = "45";
            this.cell45.UseVisualStyleBackColor = true;
            this.cell45.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell46
            // 
            this.cell46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell46.Location = new System.Drawing.Point(409, 296);
            this.cell46.Margin = new System.Windows.Forms.Padding(4);
            this.cell46.Name = "cell46";
            this.cell46.Size = new System.Drawing.Size(73, 65);
            this.cell46.TabIndex = 45;
            this.cell46.Text = "46";
            this.cell46.UseVisualStyleBackColor = true;
            this.cell46.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell47
            // 
            this.cell47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell47.Location = new System.Drawing.Point(490, 296);
            this.cell47.Margin = new System.Windows.Forms.Padding(4);
            this.cell47.Name = "cell47";
            this.cell47.Size = new System.Drawing.Size(73, 65);
            this.cell47.TabIndex = 46;
            this.cell47.Text = "47";
            this.cell47.UseVisualStyleBackColor = true;
            this.cell47.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell48
            // 
            this.cell48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell48.Location = new System.Drawing.Point(571, 296);
            this.cell48.Margin = new System.Windows.Forms.Padding(4);
            this.cell48.Name = "cell48";
            this.cell48.Size = new System.Drawing.Size(73, 65);
            this.cell48.TabIndex = 47;
            this.cell48.Text = "48";
            this.cell48.UseVisualStyleBackColor = true;
            this.cell48.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell49
            // 
            this.cell49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell49.Location = new System.Drawing.Point(652, 296);
            this.cell49.Margin = new System.Windows.Forms.Padding(4);
            this.cell49.Name = "cell49";
            this.cell49.Size = new System.Drawing.Size(73, 65);
            this.cell49.TabIndex = 48;
            this.cell49.Text = "49";
            this.cell49.UseVisualStyleBackColor = true;
            this.cell49.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell50
            // 
            this.cell50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell50.Location = new System.Drawing.Point(733, 296);
            this.cell50.Margin = new System.Windows.Forms.Padding(4);
            this.cell50.Name = "cell50";
            this.cell50.Size = new System.Drawing.Size(73, 65);
            this.cell50.TabIndex = 49;
            this.cell50.Text = "50";
            this.cell50.UseVisualStyleBackColor = true;
            this.cell50.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell51
            // 
            this.cell51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell51.Location = new System.Drawing.Point(4, 369);
            this.cell51.Margin = new System.Windows.Forms.Padding(4);
            this.cell51.Name = "cell51";
            this.cell51.Size = new System.Drawing.Size(73, 65);
            this.cell51.TabIndex = 50;
            this.cell51.Text = "51";
            this.cell51.UseVisualStyleBackColor = true;
            this.cell51.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell52
            // 
            this.cell52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell52.Location = new System.Drawing.Point(85, 369);
            this.cell52.Margin = new System.Windows.Forms.Padding(4);
            this.cell52.Name = "cell52";
            this.cell52.Size = new System.Drawing.Size(73, 65);
            this.cell52.TabIndex = 51;
            this.cell52.Text = "52";
            this.cell52.UseVisualStyleBackColor = true;
            this.cell52.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell53
            // 
            this.cell53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell53.Location = new System.Drawing.Point(166, 369);
            this.cell53.Margin = new System.Windows.Forms.Padding(4);
            this.cell53.Name = "cell53";
            this.cell53.Size = new System.Drawing.Size(73, 65);
            this.cell53.TabIndex = 52;
            this.cell53.Text = "53";
            this.cell53.UseVisualStyleBackColor = true;
            this.cell53.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell54
            // 
            this.cell54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell54.Location = new System.Drawing.Point(247, 369);
            this.cell54.Margin = new System.Windows.Forms.Padding(4);
            this.cell54.Name = "cell54";
            this.cell54.Size = new System.Drawing.Size(73, 65);
            this.cell54.TabIndex = 53;
            this.cell54.Text = "54";
            this.cell54.UseVisualStyleBackColor = true;
            this.cell54.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell55
            // 
            this.cell55.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell55.Location = new System.Drawing.Point(328, 369);
            this.cell55.Margin = new System.Windows.Forms.Padding(4);
            this.cell55.Name = "cell55";
            this.cell55.Size = new System.Drawing.Size(73, 65);
            this.cell55.TabIndex = 54;
            this.cell55.Text = "55";
            this.cell55.UseVisualStyleBackColor = true;
            this.cell55.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell56
            // 
            this.cell56.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell56.Location = new System.Drawing.Point(409, 369);
            this.cell56.Margin = new System.Windows.Forms.Padding(4);
            this.cell56.Name = "cell56";
            this.cell56.Size = new System.Drawing.Size(73, 65);
            this.cell56.TabIndex = 55;
            this.cell56.Text = "56";
            this.cell56.UseVisualStyleBackColor = true;
            this.cell56.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell57
            // 
            this.cell57.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell57.Location = new System.Drawing.Point(490, 369);
            this.cell57.Margin = new System.Windows.Forms.Padding(4);
            this.cell57.Name = "cell57";
            this.cell57.Size = new System.Drawing.Size(73, 65);
            this.cell57.TabIndex = 56;
            this.cell57.Text = "57";
            this.cell57.UseVisualStyleBackColor = true;
            this.cell57.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell58
            // 
            this.cell58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell58.Location = new System.Drawing.Point(571, 369);
            this.cell58.Margin = new System.Windows.Forms.Padding(4);
            this.cell58.Name = "cell58";
            this.cell58.Size = new System.Drawing.Size(73, 65);
            this.cell58.TabIndex = 57;
            this.cell58.Text = "58";
            this.cell58.UseVisualStyleBackColor = true;
            this.cell58.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell59
            // 
            this.cell59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell59.Location = new System.Drawing.Point(652, 369);
            this.cell59.Margin = new System.Windows.Forms.Padding(4);
            this.cell59.Name = "cell59";
            this.cell59.Size = new System.Drawing.Size(73, 65);
            this.cell59.TabIndex = 58;
            this.cell59.Text = "59";
            this.cell59.UseVisualStyleBackColor = true;
            this.cell59.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell60
            // 
            this.cell60.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell60.Location = new System.Drawing.Point(733, 369);
            this.cell60.Margin = new System.Windows.Forms.Padding(4);
            this.cell60.Name = "cell60";
            this.cell60.Size = new System.Drawing.Size(73, 65);
            this.cell60.TabIndex = 59;
            this.cell60.Text = "60";
            this.cell60.UseVisualStyleBackColor = true;
            this.cell60.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell61
            // 
            this.cell61.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell61.Location = new System.Drawing.Point(4, 442);
            this.cell61.Margin = new System.Windows.Forms.Padding(4);
            this.cell61.Name = "cell61";
            this.cell61.Size = new System.Drawing.Size(73, 65);
            this.cell61.TabIndex = 60;
            this.cell61.Text = "61";
            this.cell61.UseVisualStyleBackColor = true;
            this.cell61.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell62
            // 
            this.cell62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell62.Location = new System.Drawing.Point(85, 442);
            this.cell62.Margin = new System.Windows.Forms.Padding(4);
            this.cell62.Name = "cell62";
            this.cell62.Size = new System.Drawing.Size(73, 65);
            this.cell62.TabIndex = 61;
            this.cell62.Text = "62";
            this.cell62.UseVisualStyleBackColor = true;
            this.cell62.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell63
            // 
            this.cell63.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell63.Location = new System.Drawing.Point(166, 442);
            this.cell63.Margin = new System.Windows.Forms.Padding(4);
            this.cell63.Name = "cell63";
            this.cell63.Size = new System.Drawing.Size(73, 65);
            this.cell63.TabIndex = 62;
            this.cell63.Text = "63";
            this.cell63.UseVisualStyleBackColor = true;
            this.cell63.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell64
            // 
            this.cell64.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell64.Location = new System.Drawing.Point(247, 442);
            this.cell64.Margin = new System.Windows.Forms.Padding(4);
            this.cell64.Name = "cell64";
            this.cell64.Size = new System.Drawing.Size(73, 65);
            this.cell64.TabIndex = 63;
            this.cell64.Text = "64";
            this.cell64.UseVisualStyleBackColor = true;
            this.cell64.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell65
            // 
            this.cell65.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell65.Location = new System.Drawing.Point(328, 442);
            this.cell65.Margin = new System.Windows.Forms.Padding(4);
            this.cell65.Name = "cell65";
            this.cell65.Size = new System.Drawing.Size(73, 65);
            this.cell65.TabIndex = 64;
            this.cell65.Text = "65";
            this.cell65.UseVisualStyleBackColor = true;
            this.cell65.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell66
            // 
            this.cell66.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell66.Location = new System.Drawing.Point(409, 442);
            this.cell66.Margin = new System.Windows.Forms.Padding(4);
            this.cell66.Name = "cell66";
            this.cell66.Size = new System.Drawing.Size(73, 65);
            this.cell66.TabIndex = 65;
            this.cell66.Text = "66";
            this.cell66.UseVisualStyleBackColor = true;
            this.cell66.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell67
            // 
            this.cell67.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell67.Location = new System.Drawing.Point(490, 442);
            this.cell67.Margin = new System.Windows.Forms.Padding(4);
            this.cell67.Name = "cell67";
            this.cell67.Size = new System.Drawing.Size(73, 65);
            this.cell67.TabIndex = 66;
            this.cell67.Text = "67";
            this.cell67.UseVisualStyleBackColor = true;
            this.cell67.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell68
            // 
            this.cell68.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell68.Location = new System.Drawing.Point(571, 442);
            this.cell68.Margin = new System.Windows.Forms.Padding(4);
            this.cell68.Name = "cell68";
            this.cell68.Size = new System.Drawing.Size(73, 65);
            this.cell68.TabIndex = 67;
            this.cell68.Text = "68";
            this.cell68.UseVisualStyleBackColor = true;
            this.cell68.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell69
            // 
            this.cell69.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell69.Location = new System.Drawing.Point(652, 442);
            this.cell69.Margin = new System.Windows.Forms.Padding(4);
            this.cell69.Name = "cell69";
            this.cell69.Size = new System.Drawing.Size(73, 65);
            this.cell69.TabIndex = 68;
            this.cell69.Text = "69";
            this.cell69.UseVisualStyleBackColor = true;
            this.cell69.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell70
            // 
            this.cell70.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell70.Location = new System.Drawing.Point(733, 442);
            this.cell70.Margin = new System.Windows.Forms.Padding(4);
            this.cell70.Name = "cell70";
            this.cell70.Size = new System.Drawing.Size(73, 65);
            this.cell70.TabIndex = 69;
            this.cell70.Text = "70";
            this.cell70.UseVisualStyleBackColor = true;
            this.cell70.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell71
            // 
            this.cell71.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell71.Location = new System.Drawing.Point(4, 515);
            this.cell71.Margin = new System.Windows.Forms.Padding(4);
            this.cell71.Name = "cell71";
            this.cell71.Size = new System.Drawing.Size(73, 65);
            this.cell71.TabIndex = 70;
            this.cell71.Text = "71";
            this.cell71.UseVisualStyleBackColor = true;
            this.cell71.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell72
            // 
            this.cell72.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell72.Location = new System.Drawing.Point(85, 515);
            this.cell72.Margin = new System.Windows.Forms.Padding(4);
            this.cell72.Name = "cell72";
            this.cell72.Size = new System.Drawing.Size(73, 65);
            this.cell72.TabIndex = 71;
            this.cell72.Text = "72";
            this.cell72.UseVisualStyleBackColor = true;
            this.cell72.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell73
            // 
            this.cell73.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell73.Location = new System.Drawing.Point(166, 515);
            this.cell73.Margin = new System.Windows.Forms.Padding(4);
            this.cell73.Name = "cell73";
            this.cell73.Size = new System.Drawing.Size(73, 65);
            this.cell73.TabIndex = 72;
            this.cell73.Text = "73";
            this.cell73.UseVisualStyleBackColor = true;
            this.cell73.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell74
            // 
            this.cell74.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell74.Location = new System.Drawing.Point(247, 515);
            this.cell74.Margin = new System.Windows.Forms.Padding(4);
            this.cell74.Name = "cell74";
            this.cell74.Size = new System.Drawing.Size(73, 65);
            this.cell74.TabIndex = 73;
            this.cell74.Text = "74";
            this.cell74.UseVisualStyleBackColor = true;
            this.cell74.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell75
            // 
            this.cell75.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell75.Location = new System.Drawing.Point(328, 515);
            this.cell75.Margin = new System.Windows.Forms.Padding(4);
            this.cell75.Name = "cell75";
            this.cell75.Size = new System.Drawing.Size(73, 65);
            this.cell75.TabIndex = 74;
            this.cell75.Text = "75";
            this.cell75.UseVisualStyleBackColor = true;
            this.cell75.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell76
            // 
            this.cell76.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell76.Location = new System.Drawing.Point(409, 515);
            this.cell76.Margin = new System.Windows.Forms.Padding(4);
            this.cell76.Name = "cell76";
            this.cell76.Size = new System.Drawing.Size(73, 65);
            this.cell76.TabIndex = 75;
            this.cell76.Text = "76";
            this.cell76.UseVisualStyleBackColor = true;
            this.cell76.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell77
            // 
            this.cell77.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell77.Location = new System.Drawing.Point(490, 515);
            this.cell77.Margin = new System.Windows.Forms.Padding(4);
            this.cell77.Name = "cell77";
            this.cell77.Size = new System.Drawing.Size(73, 65);
            this.cell77.TabIndex = 76;
            this.cell77.Text = "77";
            this.cell77.UseVisualStyleBackColor = true;
            this.cell77.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell78
            // 
            this.cell78.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell78.Location = new System.Drawing.Point(571, 515);
            this.cell78.Margin = new System.Windows.Forms.Padding(4);
            this.cell78.Name = "cell78";
            this.cell78.Size = new System.Drawing.Size(73, 65);
            this.cell78.TabIndex = 77;
            this.cell78.Text = "78";
            this.cell78.UseVisualStyleBackColor = true;
            this.cell78.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell79
            // 
            this.cell79.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell79.Location = new System.Drawing.Point(652, 515);
            this.cell79.Margin = new System.Windows.Forms.Padding(4);
            this.cell79.Name = "cell79";
            this.cell79.Size = new System.Drawing.Size(73, 65);
            this.cell79.TabIndex = 78;
            this.cell79.Text = "79";
            this.cell79.UseVisualStyleBackColor = true;
            this.cell79.Click += new System.EventHandler(this.Spot_Click);
            // 
            // cell80
            // 
            this.cell80.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cell80.Location = new System.Drawing.Point(733, 515);
            this.cell80.Margin = new System.Windows.Forms.Padding(4);
            this.cell80.Name = "cell80";
            this.cell80.Size = new System.Drawing.Size(73, 65);
            this.cell80.TabIndex = 79;
            this.cell80.Text = "80";
            this.cell80.UseVisualStyleBackColor = true;
            this.cell80.Click += new System.EventHandler(this.Spot_Click);
            // 
            // gameStartBtn
            // 
            this.gameStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameStartBtn.Location = new System.Drawing.Point(12, 466);
            this.gameStartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameStartBtn.Name = "gameStartBtn";
            this.gameStartBtn.Size = new System.Drawing.Size(205, 42);
            this.gameStartBtn.TabIndex = 2;
            this.gameStartBtn.Text = "Начать игру";
            this.gameStartBtn.UseVisualStyleBackColor = true;
            this.gameStartBtn.Click += new System.EventHandler(this.gameStartBtn_Click);
            // 
            // betNumeric
            // 
            this.betNumeric.DecimalPlaces = 1;
            this.betNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.betNumeric.Location = new System.Drawing.Point(9, 63);
            this.betNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.betNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.betNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(191, 22);
            this.betNumeric.TabIndex = 4;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.betNumeric.ValueChanged += new System.EventHandler(this.SetBet_ValueChange);
            this.betNumeric.Leave += new System.EventHandler(this.SetBet_ValueChange);
            // 
            // betLabel
            // 
            this.betLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betLabel.ForeColor = System.Drawing.Color.White;
            this.betLabel.Location = new System.Drawing.Point(4, 25);
            this.betLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(161, 34);
            this.betLabel.TabIndex = 0;
            this.betLabel.Text = "Ставка";
            // 
            // attemptLabel
            // 
            this.attemptLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.attemptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attemptLabel.ForeColor = System.Drawing.Color.White;
            this.attemptLabel.Location = new System.Drawing.Point(1, 107);
            this.attemptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attemptLabel.Name = "attemptLabel";
            this.attemptLabel.Size = new System.Drawing.Size(192, 23);
            this.attemptLabel.TabIndex = 5;
            this.attemptLabel.Text = "Кол-во попыток";
            // 
            // attemptNumeric
            // 
            this.attemptNumeric.Location = new System.Drawing.Point(6, 149);
            this.attemptNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.attemptNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.attemptNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attemptNumeric.Name = "attemptNumeric";
            this.attemptNumeric.Size = new System.Drawing.Size(193, 22);
            this.attemptNumeric.TabIndex = 6;
            this.attemptNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.attemptNumeric.ValueChanged += new System.EventHandler(this.SetAttemptsCount_ValueChange);
            this.attemptNumeric.Leave += new System.EventHandler(this.SetAttemptsCount_ValueChange);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(12, 393);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(205, 42);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Очистить поле";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Clear_Click);
            // 
            // winningLabel
            // 
            this.winningLabel.AutoSize = true;
            this.winningLabel.BackColor = System.Drawing.Color.MidnightBlue;
            this.winningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winningLabel.ForeColor = System.Drawing.Color.White;
            this.winningLabel.Location = new System.Drawing.Point(95, 233);
            this.winningLabel.Name = "winningLabel";
            this.winningLabel.Size = new System.Drawing.Size(0, 20);
            this.winningLabel.TabIndex = 10;
            this.winningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.betLabel);
            this.groupBox1.Controls.Add(this.betNumeric);
            this.groupBox1.Controls.Add(this.attemptNumeric);
            this.groupBox1.Controls.Add(this.attemptLabel);
            this.groupBox1.Controls.Add(this.gameStartBtn);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Location = new System.Drawing.Point(1141, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 581);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // playerBankLabel
            // 
            this.playerBankLabel.AutoSize = true;
            this.playerBankLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerBankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerBankLabel.ForeColor = System.Drawing.Color.White;
            this.playerBankLabel.Location = new System.Drawing.Point(80, 31);
            this.playerBankLabel.Name = "playerBankLabel";
            this.playerBankLabel.Size = new System.Drawing.Size(92, 38);
            this.playerBankLabel.TabIndex = 9;
            this.playerBankLabel.Text = "Банк";
            // 
            // playerBank
            // 
            this.playerBank.BackColor = System.Drawing.Color.Transparent;
            this.playerBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerBank.ForeColor = System.Drawing.Color.White;
            this.playerBank.Location = new System.Drawing.Point(80, 92);
            this.playerBank.Name = "playerBank";
            this.playerBank.Size = new System.Drawing.Size(150, 50);
            this.playerBank.TabIndex = 8;
            this.playerBank.Text = "1000";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.playerBank);
            this.groupBox2.Controls.Add(this.playerBankLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 581);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 759);
            this.Controls.Add(this.winningLabel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keno";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attemptNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cell1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button cell2;
        private System.Windows.Forms.Button cell3;
        private System.Windows.Forms.Button cell4;
        private System.Windows.Forms.Button cell5;
        private System.Windows.Forms.Button cell6;
        private System.Windows.Forms.Button cell7;
        private System.Windows.Forms.Button cell8;
        private System.Windows.Forms.Button cell9;
        private System.Windows.Forms.Button cell10;
        private System.Windows.Forms.Button cell11;
        private System.Windows.Forms.Button cell12;
        private System.Windows.Forms.Button cell13;
        private System.Windows.Forms.Button cell14;
        private System.Windows.Forms.Button cell15;
        private System.Windows.Forms.Button cell16;
        private System.Windows.Forms.Button cell17;
        private System.Windows.Forms.Button cell18;
        private System.Windows.Forms.Button cell19;
        private System.Windows.Forms.Button cell20;
        private System.Windows.Forms.Button cell21;
        private System.Windows.Forms.Button cell22;
        private System.Windows.Forms.Button cell23;
        private System.Windows.Forms.Button cell24;
        private System.Windows.Forms.Button cell25;
        private System.Windows.Forms.Button cell26;
        private System.Windows.Forms.Button cell27;
        private System.Windows.Forms.Button cell28;
        private System.Windows.Forms.Button cell29;
        private System.Windows.Forms.Button cell30;
        private System.Windows.Forms.Button cell31;
        private System.Windows.Forms.Button cell32;
        private System.Windows.Forms.Button cell33;
        private System.Windows.Forms.Button cell34;
        private System.Windows.Forms.Button cell35;
        private System.Windows.Forms.Button cell36;
        private System.Windows.Forms.Button cell37;
        private System.Windows.Forms.Button cell38;
        private System.Windows.Forms.Button cell39;
        private System.Windows.Forms.Button cell40;
        private System.Windows.Forms.Button cell41;
        private System.Windows.Forms.Button cell42;
        private System.Windows.Forms.Button cell43;
        private System.Windows.Forms.Button cell44;
        private System.Windows.Forms.Button cell45;
        private System.Windows.Forms.Button cell46;
        private System.Windows.Forms.Button cell47;
        private System.Windows.Forms.Button cell48;
        private System.Windows.Forms.Button cell49;
        private System.Windows.Forms.Button cell50;
        private System.Windows.Forms.Button cell51;
        private System.Windows.Forms.Button cell52;
        private System.Windows.Forms.Button cell53;
        private System.Windows.Forms.Button cell54;
        private System.Windows.Forms.Button cell55;
        private System.Windows.Forms.Button cell56;
        private System.Windows.Forms.Button cell57;
        private System.Windows.Forms.Button cell58;
        private System.Windows.Forms.Button cell59;
        private System.Windows.Forms.Button cell60;
        private System.Windows.Forms.Button cell61;
        private System.Windows.Forms.Button cell62;
        private System.Windows.Forms.Button cell63;
        private System.Windows.Forms.Button cell64;
        private System.Windows.Forms.Button cell65;
        private System.Windows.Forms.Button cell66;
        private System.Windows.Forms.Button cell67;
        private System.Windows.Forms.Button cell68;
        private System.Windows.Forms.Button cell69;
        private System.Windows.Forms.Button cell70;
        private System.Windows.Forms.Button cell71;
        private System.Windows.Forms.Button cell72;
        private System.Windows.Forms.Button cell73;
        private System.Windows.Forms.Button cell74;
        private System.Windows.Forms.Button cell75;
        private System.Windows.Forms.Button cell76;
        private System.Windows.Forms.Button cell77;
        private System.Windows.Forms.Button cell78;
        private System.Windows.Forms.Button cell79;
        private System.Windows.Forms.Button cell80;
        private System.Windows.Forms.Button gameStartBtn;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label attemptLabel;
        private System.Windows.Forms.NumericUpDown attemptNumeric;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label winningLabel;
        private GroupBox groupBox1;
        private Label playerBankLabel;
        private Label playerBank;
        private GroupBox groupBox2;
    }
}

