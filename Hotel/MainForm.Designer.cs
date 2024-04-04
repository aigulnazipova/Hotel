namespace Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkingOutButton = new System.Windows.Forms.RadioButton();
            this.occupiedButton = new System.Windows.Forms.RadioButton();
            this.freeButton = new System.Windows.Forms.RadioButton();
            this.reservedButton = new System.Windows.Forms.RadioButton();
            this.statusHeader = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guestCardButton = new System.Windows.Forms.Button();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.checkOutTextBox = new System.Windows.Forms.TextBox();
            this.checkinLabel = new System.Windows.Forms.Label();
            this.checkInTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roomLabel = new System.Windows.Forms.Label();
            this.dgwGuests = new System.Windows.Forms.DataGridView();
            this.guestsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkingOutButton);
            this.panel1.Controls.Add(this.occupiedButton);
            this.panel1.Controls.Add(this.freeButton);
            this.panel1.Controls.Add(this.reservedButton);
            this.panel1.Controls.Add(this.statusHeader);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 644);
            this.panel1.TabIndex = 0;
            // 
            // checkingOutButton
            // 
            this.checkingOutButton.AutoSize = true;
            this.checkingOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkingOutButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkingOutButton.Location = new System.Drawing.Point(22, 219);
            this.checkingOutButton.Name = "checkingOutButton";
            this.checkingOutButton.Size = new System.Drawing.Size(189, 27);
            this.checkingOutButton.TabIndex = 10;
            this.checkingOutButton.TabStop = true;
            this.checkingOutButton.Text = "Выписываются";
            this.checkingOutButton.UseVisualStyleBackColor = true;
            // 
            // occupiedButton
            // 
            this.occupiedButton.AutoSize = true;
            this.occupiedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.occupiedButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.occupiedButton.Location = new System.Drawing.Point(22, 177);
            this.occupiedButton.Name = "occupiedButton";
            this.occupiedButton.Size = new System.Drawing.Size(109, 27);
            this.occupiedButton.TabIndex = 9;
            this.occupiedButton.TabStop = true;
            this.occupiedButton.Text = "Заняты";
            this.occupiedButton.UseVisualStyleBackColor = true;
            // 
            // freeButton
            // 
            this.freeButton.AutoSize = true;
            this.freeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeButton.Location = new System.Drawing.Point(22, 135);
            this.freeButton.Name = "freeButton";
            this.freeButton.Size = new System.Drawing.Size(143, 27);
            this.freeButton.TabIndex = 8;
            this.freeButton.TabStop = true;
            this.freeButton.Text = "Свободные";
            this.freeButton.UseVisualStyleBackColor = true;
            // 
            // reservedButton
            // 
            this.reservedButton.AutoSize = true;
            this.reservedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservedButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservedButton.Location = new System.Drawing.Point(22, 93);
            this.reservedButton.Name = "reservedButton";
            this.reservedButton.Size = new System.Drawing.Size(208, 27);
            this.reservedButton.TabIndex = 7;
            this.reservedButton.TabStop = true;
            this.reservedButton.Text = "Зарезервировано";
            this.reservedButton.UseVisualStyleBackColor = true;
            // 
            // statusHeader
            // 
            this.statusHeader.AutoSize = true;
            this.statusHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusHeader.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusHeader.Location = new System.Drawing.Point(67, 18);
            this.statusHeader.Name = "statusHeader";
            this.statusHeader.Size = new System.Drawing.Size(122, 39);
            this.statusHeader.TabIndex = 5;
            this.statusHeader.Text = "Статус";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 642);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.searchTextbox);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 67);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(148, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Время";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(1037, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(42, 41);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 3;
            this.searchButton.TabStop = false;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextbox.Location = new System.Drawing.Point(514, 13);
            this.searchTextbox.Multiline = true;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(517, 41);
            this.searchTextbox.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.guestCardButton);
            this.panel3.Controls.Add(this.checkoutLabel);
            this.panel3.Controls.Add(this.checkOutTextBox);
            this.panel3.Controls.Add(this.checkinLabel);
            this.panel3.Controls.Add(this.checkInTextBox);
            this.panel3.Controls.Add(this.fullNameLabel);
            this.panel3.Controls.Add(this.fullNameTextBox);
            this.panel3.Controls.Add(this.statusLabel);
            this.panel3.Controls.Add(this.statusTextBox);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.roomLabel);
            this.panel3.Location = new System.Drawing.Point(910, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 644);
            this.panel3.TabIndex = 1;
            // 
            // guestCardButton
            // 
            this.guestCardButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guestCardButton.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestCardButton.Location = new System.Drawing.Point(108, 576);
            this.guestCardButton.Name = "guestCardButton";
            this.guestCardButton.Size = new System.Drawing.Size(243, 45);
            this.guestCardButton.TabIndex = 16;
            this.guestCardButton.Text = "Просмотр карточки";
            this.guestCardButton.UseVisualStyleBackColor = false;
            this.guestCardButton.Click += new System.EventHandler(this.guestCardButton_Click);
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkoutLabel.Location = new System.Drawing.Point(20, 498);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(119, 21);
            this.checkoutLabel.TabIndex = 15;
            this.checkoutLabel.Text = "Дата выезда";
            // 
            // checkOutTextBox
            // 
            this.checkOutTextBox.Location = new System.Drawing.Point(24, 522);
            this.checkOutTextBox.Multiline = true;
            this.checkOutTextBox.Name = "checkOutTextBox";
            this.checkOutTextBox.Size = new System.Drawing.Size(159, 36);
            this.checkOutTextBox.TabIndex = 14;
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkinLabel.Location = new System.Drawing.Point(20, 421);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(113, 21);
            this.checkinLabel.TabIndex = 13;
            this.checkinLabel.Text = "Дата заезда";
            // 
            // checkInTextBox
            // 
            this.checkInTextBox.Location = new System.Drawing.Point(24, 445);
            this.checkInTextBox.Multiline = true;
            this.checkInTextBox.Name = "checkInTextBox";
            this.checkInTextBox.Size = new System.Drawing.Size(159, 36);
            this.checkInTextBox.TabIndex = 12;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(20, 347);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(52, 21);
            this.fullNameLabel.TabIndex = 11;
            this.fullNameLabel.Text = "ФИО";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(24, 371);
            this.fullNameTextBox.Multiline = true;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(255, 36);
            this.fullNameTextBox.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(20, 277);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 21);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Статус";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(24, 301);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(159, 36);
            this.statusTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 183);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomLabel.Location = new System.Drawing.Point(33, 18);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(159, 39);
            this.roomLabel.TabIndex = 7;
            this.roomLabel.Text = "Номер №";
            // 
            // dgwGuests
            // 
            this.dgwGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwGuests.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGuests.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgwGuests.Location = new System.Drawing.Point(263, 236);
            this.dgwGuests.Name = "dgwGuests";
            this.dgwGuests.RowHeadersWidth = 51;
            this.dgwGuests.RowTemplate.Height = 24;
            this.dgwGuests.Size = new System.Drawing.Size(641, 472);
            this.dgwGuests.TabIndex = 4;
            // 
            // guestsLabel
            // 
            this.guestsLabel.AutoSize = true;
            this.guestsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guestsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestsLabel.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestsLabel.Location = new System.Drawing.Point(279, 84);
            this.guestsLabel.Name = "guestsLabel";
            this.guestsLabel.Size = new System.Drawing.Size(238, 39);
            this.guestsLabel.TabIndex = 6;
            this.guestsLabel.Text = "Список гостей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1288, 709);
            this.Controls.Add(this.guestsLabel);
            this.Controls.Add(this.dgwGuests);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.DataGridView dgwGuests;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label statusHeader;
        private System.Windows.Forms.Label guestsLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.RadioButton reservedButton;
        private System.Windows.Forms.RadioButton checkingOutButton;
        private System.Windows.Forms.RadioButton occupiedButton;
        private System.Windows.Forms.RadioButton freeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button guestCardButton;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.TextBox checkOutTextBox;
        private System.Windows.Forms.Label checkinLabel;
        private System.Windows.Forms.TextBox checkInTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}

