namespace Assignment3
{
    partial class MainForm
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
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtnCancel = new System.Windows.Forms.RadioButton();
            this.rbtnReserve = new System.Windows.Forms.RadioButton();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblRsvdSeats = new System.Windows.Forms.Label();
            this.lblVacSeats = new System.Windows.Forms.Label();
            this.lblTotSeats = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstlblSeat = new System.Windows.Forms.Label();
            this.lstlblStatus = new System.Windows.Forms.Label();
            this.lstlblName = new System.Windows.Forms.Label();
            this.lstlblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReservations
            // 
            this.lstReservations.AccessibleName = "lstReservations";
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 15;
            this.lstReservations.Location = new System.Drawing.Point(329, 27);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(222, 244);
            this.lstReservations.TabIndex = 0;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // grpInput
            // 
            this.grpInput.AccessibleName = "grpInput";
            this.grpInput.Controls.Add(this.txtPrice);
            this.grpInput.Controls.Add(this.lblPrice);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.rbtnCancel);
            this.grpInput.Controls.Add(this.rbtnReserve);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(311, 90);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Data";
            // 
            // lblPrice
            // 
            this.lblPrice.AccessibleName = "lblPrice";
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(179, 43);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "txtName";
            this.txtName.Location = new System.Drawing.Point(6, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 23);
            this.txtName.TabIndex = 4;
            this.txtName.Tag = "";
            this.txtName.Text = "Enter name..";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.AccessibleName = "rbtnCancel";
            this.rbtnCancel.AutoSize = true;
            this.rbtnCancel.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbtnCancel.Location = new System.Drawing.Point(182, 22);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(123, 19);
            this.rbtnCancel.TabIndex = 3;
            this.rbtnCancel.TabStop = true;
            this.rbtnCancel.Text = "Cancel Reservation";
            this.rbtnCancel.UseVisualStyleBackColor = true;
            this.rbtnCancel.CheckedChanged += new System.EventHandler(this.rbtnCancel_CheckedChanged);
            // 
            // rbtnReserve
            // 
            this.rbtnReserve.AccessibleName = "rbtnReserve";
            this.rbtnReserve.AutoSize = true;
            this.rbtnReserve.ForeColor = System.Drawing.Color.DarkBlue;
            this.rbtnReserve.Location = new System.Drawing.Point(6, 22);
            this.rbtnReserve.Name = "rbtnReserve";
            this.rbtnReserve.Size = new System.Drawing.Size(115, 19);
            this.rbtnReserve.TabIndex = 2;
            this.rbtnReserve.TabStop = true;
            this.rbtnReserve.Text = "Make reservation";
            this.rbtnReserve.UseVisualStyleBackColor = true;
            this.rbtnReserve.CheckedChanged += new System.EventHandler(this.rbtnReserve_CheckedChanged);
            // 
            // grpOutput
            // 
            this.grpOutput.AccessibleName = "grpOutput";
            this.grpOutput.Controls.Add(this.lblRsvdSeats);
            this.grpOutput.Controls.Add(this.lblVacSeats);
            this.grpOutput.Controls.Add(this.lblTotSeats);
            this.grpOutput.Location = new System.Drawing.Point(12, 154);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(311, 113);
            this.grpOutput.TabIndex = 0;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output Data";
            // 
            // lblRsvdSeats
            // 
            this.lblRsvdSeats.AccessibleName = "lblRsvdSeats";
            this.lblRsvdSeats.AutoSize = true;
            this.lblRsvdSeats.Location = new System.Drawing.Point(6, 81);
            this.lblRsvdSeats.Name = "lblRsvdSeats";
            this.lblRsvdSeats.Size = new System.Drawing.Size(145, 15);
            this.lblRsvdSeats.TabIndex = 2;
            this.lblRsvdSeats.Text = "Number of reserved seats: ";
            this.lblRsvdSeats.Click += new System.EventHandler(this.lblRsvdSeats_Click);
            // 
            // lblVacSeats
            // 
            this.lblVacSeats.AccessibleName = "lblVacSeats";
            this.lblVacSeats.AutoSize = true;
            this.lblVacSeats.Location = new System.Drawing.Point(6, 51);
            this.lblVacSeats.Name = "lblVacSeats";
            this.lblVacSeats.Size = new System.Drawing.Size(134, 15);
            this.lblVacSeats.TabIndex = 1;
            this.lblVacSeats.Text = "Number of vacant seats: ";
            // 
            // lblTotSeats
            // 
            this.lblTotSeats.AccessibleName = "lblTotSeats";
            this.lblTotSeats.AutoSize = true;
            this.lblTotSeats.Location = new System.Drawing.Point(6, 19);
            this.lblTotSeats.Name = "lblTotSeats";
            this.lblTotSeats.Size = new System.Drawing.Size(123, 15);
            this.lblTotSeats.TabIndex = 0;
            this.lblTotSeats.Text = "Total number of seats: ";
            this.lblTotSeats.Click += new System.EventHandler(this.lblTotSeats_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleName = "btnOK";
            this.btnOK.Location = new System.Drawing.Point(115, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 40);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstlblSeat
            // 
            this.lstlblSeat.AccessibleName = "lstlblSeat";
            this.lstlblSeat.AutoSize = true;
            this.lstlblSeat.Location = new System.Drawing.Point(329, 9);
            this.lstlblSeat.Name = "lstlblSeat";
            this.lstlblSeat.Size = new System.Drawing.Size(31, 15);
            this.lstlblSeat.TabIndex = 2;
            this.lstlblSeat.Text = "Seat";
            this.lstlblSeat.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstlblStatus
            // 
            this.lstlblStatus.AccessibleName = "lstlblStatus";
            this.lstlblStatus.AutoSize = true;
            this.lstlblStatus.Location = new System.Drawing.Point(371, 9);
            this.lstlblStatus.Name = "lstlblStatus";
            this.lstlblStatus.Size = new System.Drawing.Size(40, 15);
            this.lstlblStatus.TabIndex = 3;
            this.lstlblStatus.Text = "Status";
            this.lstlblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // lstlblName
            // 
            this.lstlblName.AccessibleName = "lstlblName";
            this.lstlblName.AutoSize = true;
            this.lstlblName.Location = new System.Drawing.Point(442, 9);
            this.lstlblName.Name = "lstlblName";
            this.lstlblName.Size = new System.Drawing.Size(36, 15);
            this.lstlblName.TabIndex = 4;
            this.lstlblName.Text = "Name";
            // 
            // lstlblPrice
            // 
            this.lstlblPrice.AccessibleName = "lstlblPrice";
            this.lstlblPrice.AutoSize = true;
            this.lstlblPrice.Location = new System.Drawing.Point(502, 9);
            this.lstlblPrice.Name = "lstlblPrice";
            this.lstlblPrice.Size = new System.Drawing.Size(34, 15);
            this.lstlblPrice.TabIndex = 5;
            this.lstlblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.AccessibleName = "txtPrice";
            this.txtPrice.Location = new System.Drawing.Point(182, 61);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 23);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Tag = "";
            this.txtPrice.Text = "Enter price..";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(563, 274);
            this.Controls.Add(this.lstlblPrice);
            this.Controls.Add(this.lstlblName);
            this.Controls.Add(this.lstlblStatus);
            this.Controls.Add(this.lstlblSeat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lstReservations);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "MainForm";
            this.Text = "Cinema Booking System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbtnCancel;
        private System.Windows.Forms.RadioButton rbtnReserve;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTotSeats;
        private System.Windows.Forms.Label lblRsvdSeats;
        private System.Windows.Forms.Label lblVacSeats;
        private System.Windows.Forms.Label lstlblSeat;
        private System.Windows.Forms.Label lstlblStatus;
        private System.Windows.Forms.Label lstlblName;
        private System.Windows.Forms.Label lstlblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

