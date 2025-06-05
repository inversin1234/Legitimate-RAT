namespace Quasar.Server.Forms
{
    partial class FrmChat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtChatInput;
        private System.Windows.Forms.RichTextBox txtChatOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtChatOutput = new System.Windows.Forms.RichTextBox();
            this.txtChatInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChatOutput
            // 
            this.txtChatOutput.BackColor = System.Drawing.Color.Black;
            this.txtChatOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChatOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChatOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtChatOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtChatOutput.Location = new System.Drawing.Point(3, 3);
            this.txtChatOutput.Name = "txtChatOutput";
            this.txtChatOutput.ReadOnly = true;
            this.txtChatOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtChatOutput.Size = new System.Drawing.Size(631, 297);
            this.txtChatOutput.TabIndex = 1;
            this.txtChatOutput.Text = "";
            this.txtChatOutput.TextChanged += new System.EventHandler(this.txtChatOutput_TextChanged);
            // 
            // txtChatInput
            // 
            this.txtChatInput.BackColor = System.Drawing.Color.Black;
            this.txtChatInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChatInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChatInput.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtChatInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtChatInput.Location = new System.Drawing.Point(3, 306);
            this.txtChatInput.MaxLength = 200;
            this.txtChatInput.Name = "txtChatInput";
            this.txtChatInput.Size = new System.Drawing.Size(631, 16);
            this.txtChatInput.TabIndex = 0;
            this.txtChatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChatInput_KeyDown);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.txtChatOutput, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtChatInput, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(637, 323);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(637, 323);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FrmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat []";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChat_FormClosing);
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
