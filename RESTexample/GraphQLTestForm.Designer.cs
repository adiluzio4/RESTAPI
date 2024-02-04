namespace RESTexample
{
    partial class GraphQLTestForm
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExecute.Location = new System.Drawing.Point(57, 340);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(348, 42);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute Query";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(57, 116);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(348, 218);
            this.txtQuery.TabIndex = 1;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(447, 116);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(209, 266);
            this.txtResponse.TabIndex = 2;
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(54, 97);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(100, 16);
            this.lblQuery.TabIndex = 3;
            this.lblQuery.Text = "GraphQL Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response";
            // 
            // txtEndpoint
            // 
            this.txtEndpoint.Location = new System.Drawing.Point(57, 63);
            this.txtEndpoint.Name = "txtEndpoint";
            this.txtEndpoint.Size = new System.Drawing.Size(599, 22);
            this.txtEndpoint.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Endpoint URI";
            // 
            // GraphQLTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(711, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnExecute);
            this.Name = "GraphQLTestForm";
            this.Text = "GraphQLTestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphQLTestForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Label label1;
    }
}