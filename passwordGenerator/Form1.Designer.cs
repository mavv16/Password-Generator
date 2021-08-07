
namespace passwordGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.radioButton_four = new System.Windows.Forms.RadioButton();
            this.radioButton_eight = new System.Windows.Forms.RadioButton();
            this.radioButton_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_fifteen = new System.Windows.Forms.RadioButton();
            this.radioButton_six = new System.Windows.Forms.RadioButton();
            this.textBox_custom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_specialChar = new System.Windows.Forms.RadioButton();
            this.radioButton_numbers = new System.Windows.Forms.RadioButton();
            this.radioButton_mix2 = new System.Windows.Forms.RadioButton();
            this.radioButton_letters = new System.Windows.Forms.RadioButton();
            this.radioButton_mix1 = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_insert = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.checkedListBox_words = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.Location = new System.Drawing.Point(83, 28);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_result.Size = new System.Drawing.Size(388, 29);
            this.textBox_result.TabIndex = 0;
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.Black;
            this.button_generate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_generate.FlatAppearance.BorderSize = 0;
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generate.ForeColor = System.Drawing.Color.CadetBlue;
            this.button_generate.Location = new System.Drawing.Point(477, 30);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(100, 29);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "GENERATE";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // radioButton_four
            // 
            this.radioButton_four.AutoSize = true;
            this.radioButton_four.Location = new System.Drawing.Point(15, 43);
            this.radioButton_four.Name = "radioButton_four";
            this.radioButton_four.Size = new System.Drawing.Size(37, 21);
            this.radioButton_four.TabIndex = 2;
            this.radioButton_four.TabStop = true;
            this.radioButton_four.Text = "4";
            this.radioButton_four.UseVisualStyleBackColor = true;
            // 
            // radioButton_eight
            // 
            this.radioButton_eight.AutoSize = true;
            this.radioButton_eight.Location = new System.Drawing.Point(15, 81);
            this.radioButton_eight.Name = "radioButton_eight";
            this.radioButton_eight.Size = new System.Drawing.Size(37, 21);
            this.radioButton_eight.TabIndex = 3;
            this.radioButton_eight.TabStop = true;
            this.radioButton_eight.Text = "8";
            this.radioButton_eight.UseVisualStyleBackColor = true;
            // 
            // radioButton_custom
            // 
            this.radioButton_custom.AutoSize = true;
            this.radioButton_custom.Location = new System.Drawing.Point(15, 118);
            this.radioButton_custom.Name = "radioButton_custom";
            this.radioButton_custom.Size = new System.Drawing.Size(78, 21);
            this.radioButton_custom.TabIndex = 4;
            this.radioButton_custom.TabStop = true;
            this.radioButton_custom.Text = "custom:";
            this.radioButton_custom.UseVisualStyleBackColor = true;
            // 
            // radioButton_fifteen
            // 
            this.radioButton_fifteen.AutoSize = true;
            this.radioButton_fifteen.Location = new System.Drawing.Point(131, 81);
            this.radioButton_fifteen.Name = "radioButton_fifteen";
            this.radioButton_fifteen.Size = new System.Drawing.Size(45, 21);
            this.radioButton_fifteen.TabIndex = 6;
            this.radioButton_fifteen.TabStop = true;
            this.radioButton_fifteen.Text = "15";
            this.radioButton_fifteen.UseVisualStyleBackColor = true;
            // 
            // radioButton_six
            // 
            this.radioButton_six.AutoSize = true;
            this.radioButton_six.Location = new System.Drawing.Point(131, 43);
            this.radioButton_six.Name = "radioButton_six";
            this.radioButton_six.Size = new System.Drawing.Size(37, 21);
            this.radioButton_six.TabIndex = 5;
            this.radioButton_six.TabStop = true;
            this.radioButton_six.Text = "6";
            this.radioButton_six.UseVisualStyleBackColor = true;
            // 
            // textBox_custom
            // 
            this.textBox_custom.BackColor = System.Drawing.Color.Black;
            this.textBox_custom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_custom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_custom.Location = new System.Drawing.Point(100, 118);
            this.textBox_custom.Multiline = true;
            this.textBox_custom.Name = "textBox_custom";
            this.textBox_custom.Size = new System.Drawing.Size(68, 22);
            this.textBox_custom.TabIndex = 7;
            this.textBox_custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.textBox_custom);
            this.groupBox1.Controls.Add(this.radioButton_four);
            this.groupBox1.Controls.Add(this.radioButton_fifteen);
            this.groupBox1.Controls.Add(this.radioButton_eight);
            this.groupBox1.Controls.Add(this.radioButton_six);
            this.groupBox1.Controls.Add(this.radioButton_custom);
            this.groupBox1.Location = new System.Drawing.Point(83, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of characters";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.radioButton_specialChar);
            this.groupBox2.Controls.Add(this.radioButton_numbers);
            this.groupBox2.Controls.Add(this.radioButton_mix2);
            this.groupBox2.Controls.Add(this.radioButton_letters);
            this.groupBox2.Controls.Add(this.radioButton_mix1);
            this.groupBox2.Location = new System.Drawing.Point(314, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 177);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of characters";
            // 
            // radioButton_specialChar
            // 
            this.radioButton_specialChar.AutoSize = true;
            this.radioButton_specialChar.Location = new System.Drawing.Point(12, 86);
            this.radioButton_specialChar.Name = "radioButton_specialChar";
            this.radioButton_specialChar.Size = new System.Drawing.Size(174, 21);
            this.radioButton_specialChar.TabIndex = 7;
            this.radioButton_specialChar.TabStop = true;
            this.radioButton_specialChar.Text = "only special characters";
            this.radioButton_specialChar.UseVisualStyleBackColor = true;
            // 
            // radioButton_numbers
            // 
            this.radioButton_numbers.AutoSize = true;
            this.radioButton_numbers.Location = new System.Drawing.Point(12, 59);
            this.radioButton_numbers.Name = "radioButton_numbers";
            this.radioButton_numbers.Size = new System.Drawing.Size(114, 21);
            this.radioButton_numbers.TabIndex = 2;
            this.radioButton_numbers.TabStop = true;
            this.radioButton_numbers.Text = "only numbers";
            this.radioButton_numbers.UseVisualStyleBackColor = true;
            // 
            // radioButton_mix2
            // 
            this.radioButton_mix2.AutoSize = true;
            this.radioButton_mix2.Location = new System.Drawing.Point(12, 147);
            this.radioButton_mix2.Name = "radioButton_mix2";
            this.radioButton_mix2.Size = new System.Drawing.Size(206, 21);
            this.radioButton_mix2.TabIndex = 6;
            this.radioButton_mix2.TabStop = true;
            this.radioButton_mix2.Text = "mix (with special characters)";
            this.radioButton_mix2.UseVisualStyleBackColor = true;
            // 
            // radioButton_letters
            // 
            this.radioButton_letters.AutoSize = true;
            this.radioButton_letters.Location = new System.Drawing.Point(12, 31);
            this.radioButton_letters.Name = "radioButton_letters";
            this.radioButton_letters.Size = new System.Drawing.Size(98, 21);
            this.radioButton_letters.TabIndex = 3;
            this.radioButton_letters.TabStop = true;
            this.radioButton_letters.Text = "only letters";
            this.radioButton_letters.UseVisualStyleBackColor = true;
            // 
            // radioButton_mix1
            // 
            this.radioButton_mix1.AutoSize = true;
            this.radioButton_mix1.Location = new System.Drawing.Point(12, 118);
            this.radioButton_mix1.Name = "radioButton_mix1";
            this.radioButton_mix1.Size = new System.Drawing.Size(226, 21);
            this.radioButton_mix1.TabIndex = 5;
            this.radioButton_mix1.TabStop = true;
            this.radioButton_mix1.Text = "mix (without special characters)";
            this.radioButton_mix1.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Controls.Add(this.textBox_insert);
            this.groupBox3.Controls.Add(this.button_insert);
            this.groupBox3.Controls.Add(this.checkedListBox_words);
            this.groupBox3.Location = new System.Drawing.Point(83, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 148);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "you have some favourite word/s ? write it ";
            // 
            // textBox_insert
            // 
            this.textBox_insert.Location = new System.Drawing.Point(15, 37);
            this.textBox_insert.Multiline = true;
            this.textBox_insert.Name = "textBox_insert";
            this.textBox_insert.Size = new System.Drawing.Size(175, 46);
            this.textBox_insert.TabIndex = 2;
            this.textBox_insert.Click += new System.EventHandler(this.textBox_insert_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.Black;
            this.button_insert.FlatAppearance.BorderSize = 0;
            this.button_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_insert.Location = new System.Drawing.Point(15, 89);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(175, 37);
            this.button_insert.TabIndex = 1;
            this.button_insert.Text = "insert word";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // checkedListBox_words
            // 
            this.checkedListBox_words.FormattingEnabled = true;
            this.checkedListBox_words.Location = new System.Drawing.Point(196, 37);
            this.checkedListBox_words.Name = "checkedListBox_words";
            this.checkedListBox_words.ScrollAlwaysVisible = true;
            this.checkedListBox_words.Size = new System.Drawing.Size(292, 89);
            this.checkedListBox_words.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(671, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.RadioButton radioButton_four;
        private System.Windows.Forms.RadioButton radioButton_eight;
        private System.Windows.Forms.RadioButton radioButton_custom;
        private System.Windows.Forms.RadioButton radioButton_fifteen;
        private System.Windows.Forms.RadioButton radioButton_six;
        private System.Windows.Forms.TextBox textBox_custom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_numbers;
        private System.Windows.Forms.RadioButton radioButton_mix2;
        private System.Windows.Forms.RadioButton radioButton_letters;
        private System.Windows.Forms.RadioButton radioButton_mix1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton radioButton_specialChar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_insert;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.CheckedListBox checkedListBox_words;
    }
}

