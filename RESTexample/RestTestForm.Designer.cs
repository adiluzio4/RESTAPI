namespace RESTexample
{
    partial class RestTestForm
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblBaseAddr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrlParams = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGET = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPOST = new System.Windows.Forms.Button();
            this.txtPostInput = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPUT = new System.Windows.Forms.RadioButton();
            this.rbPOST = new System.Windows.Forms.RadioButton();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(59, 64);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(688, 22);
            this.txtURL.TabIndex = 0;
            // 
            // lblBaseAddr
            // 
            this.lblBaseAddr.AutoSize = true;
            this.lblBaseAddr.Location = new System.Drawing.Point(56, 45);
            this.lblBaseAddr.Name = "lblBaseAddr";
            this.lblBaseAddr.Size = new System.Drawing.Size(123, 16);
            this.lblBaseAddr.TabIndex = 1;
            this.lblBaseAddr.Text = "Request Base URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL Parameters";
            // 
            // txtUrlParams
            // 
            this.txtUrlParams.Location = new System.Drawing.Point(43, 52);
            this.txtUrlParams.Name = "txtUrlParams";
            this.txtUrlParams.Size = new System.Drawing.Size(600, 22);
            this.txtUrlParams.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGet);
            this.groupBox1.Controls.Add(this.rbDelete);
            this.groupBox1.Controls.Add(this.btnGET);
            this.groupBox1.Controls.Add(this.txtUrlParams);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GET / DELETE Parameters";
            // 
            // btnGET
            // 
            this.btnGET.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGET.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGET.Location = new System.Drawing.Point(43, 86);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(600, 33);
            this.btnGET.TabIndex = 4;
            this.btnGET.Text = "GET  |  DELETE";
            this.btnGET.UseVisualStyleBackColor = false;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPOST);
            this.groupBox2.Controls.Add(this.rbPUT);
            this.groupBox2.Controls.Add(this.btnPOST);
            this.groupBox2.Controls.Add(this.txtPostInput);
            this.groupBox2.Controls.Add(this.lblContent);
            this.groupBox2.Location = new System.Drawing.Point(59, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 291);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "POST / PUT Parameters";
            // 
            // btnPOST
            // 
            this.btnPOST.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPOST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOST.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPOST.Location = new System.Drawing.Point(43, 237);
            this.btnPOST.Name = "btnPOST";
            this.btnPOST.Size = new System.Drawing.Size(600, 33);
            this.btnPOST.TabIndex = 4;
            this.btnPOST.Text = "PUT  |  POST";
            this.btnPOST.UseVisualStyleBackColor = false;
            this.btnPOST.Click += new System.EventHandler(this.btnPOST_Click);
            // 
            // txtPostInput
            // 
            this.txtPostInput.Location = new System.Drawing.Point(43, 56);
            this.txtPostInput.Multiline = true;
            this.txtPostInput.Name = "txtPostInput";
            this.txtPostInput.Size = new System.Drawing.Size(598, 175);
            this.txtPostInput.TabIndex = 2;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(40, 37);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(91, 16);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "JSON Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Consolas", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "REST HTTP Client Testing Prototype";
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResponse.Location = new System.Drawing.Point(765, 64);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(332, 480);
            this.txtResponse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Response";
            // 
            // rbPUT
            // 
            this.rbPUT.AutoSize = true;
            this.rbPUT.Location = new System.Drawing.Point(481, 30);
            this.rbPUT.Name = "rbPUT";
            this.rbPUT.Size = new System.Drawing.Size(56, 20);
            this.rbPUT.TabIndex = 5;
            this.rbPUT.TabStop = true;
            this.rbPUT.Text = "PUT";
            this.rbPUT.UseVisualStyleBackColor = true;
            // 
            // rbPOST
            // 
            this.rbPOST.AutoSize = true;
            this.rbPOST.Location = new System.Drawing.Point(580, 30);
            this.rbPOST.Name = "rbPOST";
            this.rbPOST.Size = new System.Drawing.Size(65, 20);
            this.rbPOST.TabIndex = 6;
            this.rbPOST.TabStop = true;
            this.rbPOST.Text = "POST";
            this.rbPOST.UseVisualStyleBackColor = true;
            // 
            // rbGet
            // 
            this.rbGet.AutoSize = true;
            this.rbGet.Location = new System.Drawing.Point(580, 26);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(56, 20);
            this.rbGet.TabIndex = 8;
            this.rbGet.TabStop = true;
            this.rbGet.Text = "GET";
            this.rbGet.UseVisualStyleBackColor = true;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(481, 26);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(81, 20);
            this.rbDelete.TabIndex = 7;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "DELETE";
            this.rbDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(953, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close Application";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RestTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 601);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBaseAddr);
            this.Controls.Add(this.txtURL);
            this.Name = "RestTestForm";
            this.Text = "REST Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestTestForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblBaseAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrlParams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPOST;
        private System.Windows.Forms.TextBox txtPostInput;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPOST;
        private System.Windows.Forms.RadioButton rbPUT;
        private System.Windows.Forms.RadioButton rbGet;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.Button btnClose;
    }
}

