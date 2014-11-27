namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMins = new System.Windows.Forms.Button();
            this.btnSev = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnplmi = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AcceptsReturn = true;
            this.display.AcceptsTab = true;
            this.display.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.display.Enabled = false;
            this.display.Location = new System.Drawing.Point(57, 21);
            this.display.Name = "display";
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.display.Size = new System.Drawing.Size(333, 26);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            this.display.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.BurlyWood;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlus.Location = new System.Drawing.Point(160, 100);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(51, 45);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMins
            // 
            this.btnMins.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMins.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMins.Location = new System.Drawing.Point(240, 100);
            this.btnMins.Name = "btnMins";
            this.btnMins.Size = new System.Drawing.Size(51, 45);
            this.btnMins.TabIndex = 3;
            this.btnMins.Text = "-";
            this.btnMins.UseVisualStyleBackColor = false;
            this.btnMins.Click += new System.EventHandler(this.btnMins_Click);
            // 
            // btnSev
            // 
            this.btnSev.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSev.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSev.Location = new System.Drawing.Point(80, 180);
            this.btnSev.Name = "btnSev";
            this.btnSev.Size = new System.Drawing.Size(51, 45);
            this.btnSev.TabIndex = 4;
            this.btnSev.Text = "7";
            this.btnSev.UseVisualStyleBackColor = false;
            this.btnSev.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEight.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEight.Location = new System.Drawing.Point(160, 180);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(51, 45);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.BurlyWood;
            this.btnNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNine.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNine.Location = new System.Drawing.Point(240, 180);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(51, 45);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSix.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSix.Location = new System.Drawing.Point(240, 260);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(51, 45);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.BurlyWood;
            this.btnOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOne.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOne.Location = new System.Drawing.Point(80, 340);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(51, 45);
            this.btnOne.TabIndex = 9;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFive.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFive.Location = new System.Drawing.Point(160, 260);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(51, 45);
            this.btnFive.TabIndex = 10;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFour.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFour.Location = new System.Drawing.Point(80, 260);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(51, 45);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.BurlyWood;
            this.btnThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThree.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThree.Location = new System.Drawing.Point(240, 340);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(51, 45);
            this.btnThree.TabIndex = 6;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDel.Location = new System.Drawing.Point(320, 100);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 45);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnplmi
            // 
            this.btnplmi.BackColor = System.Drawing.Color.BurlyWood;
            this.btnplmi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplmi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnplmi.Location = new System.Drawing.Point(240, 420);
            this.btnplmi.Name = "btnplmi";
            this.btnplmi.Size = new System.Drawing.Size(51, 45);
            this.btnplmi.TabIndex = 16;
            this.btnplmi.Text = "+/-";
            this.btnplmi.UseVisualStyleBackColor = false;
            this.btnplmi.Click += new System.EventHandler(this.btnplmi_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.BurlyWood;
            this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZero.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZero.Location = new System.Drawing.Point(80, 420);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(51, 45);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDot.Location = new System.Drawing.Point(160, 420);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(51, 45);
            this.btnDot.TabIndex = 14;
            this.btnDot.Text = ".";
            this.btnDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiv.Location = new System.Drawing.Point(320, 260);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(70, 45);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMul.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMul.Location = new System.Drawing.Point(320, 180);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(70, 45);
            this.btnMul.TabIndex = 18;
            this.btnMul.Text = "X";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnEqu
            // 
            this.btnEqu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEqu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEqu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEqu.Location = new System.Drawing.Point(320, 340);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(70, 125);
            this.btnEqu.TabIndex = 19;
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = false;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAC.Location = new System.Drawing.Point(80, 100);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(51, 45);
            this.btnAC.TabIndex = 20;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTwo.Location = new System.Drawing.Point(160, 340);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(51, 45);
            this.btnTwo.TabIndex = 21;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(456, 497);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnEqu);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnplmi);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSev);
            this.Controls.Add(this.btnMins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMins;
        private System.Windows.Forms.Button btnSev;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnplmi;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnTwo;
    }
}

