namespace NucleusAPIExampleUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            scriptEditor = new RichTextBox();
            executeButton = new Button();
            clearButton = new Button();
            injectButton = new Button();
            statusTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // scriptEditor
            // 
            scriptEditor.Location = new Point(12, 12);
            scriptEditor.Name = "scriptEditor";
            scriptEditor.Size = new Size(776, 397);
            scriptEditor.TabIndex = 0;
            scriptEditor.Text = "";
            // 
            // executeButton
            // 
            executeButton.Location = new Point(12, 415);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(75, 23);
            executeButton.TabIndex = 1;
            executeButton.Text = "Execute";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(93, 415);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // injectButton
            // 
            injectButton.Location = new Point(713, 415);
            injectButton.Name = "injectButton";
            injectButton.Size = new Size(75, 23);
            injectButton.TabIndex = 3;
            injectButton.Text = "Inject";
            injectButton.UseVisualStyleBackColor = true;
            injectButton.Click += injectButton_Click;
            // 
            // statusTimer
            // 
            statusTimer.Enabled = true;
            statusTimer.Tick += statusTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(injectButton);
            Controls.Add(clearButton);
            Controls.Add(executeButton);
            Controls.Add(scriptEditor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Nucleus API Example UI";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox scriptEditor;
        private Button executeButton;
        private Button clearButton;
        private Button injectButton;
        private System.Windows.Forms.Timer statusTimer;
    }
}
