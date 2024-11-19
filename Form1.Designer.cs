namespace Estructuras_Lineales
{
    partial class Form1
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
            txtInput = new TextBox();
            lstDisplay = new ListBox();
            btnAddArray = new Button();
            btnShowArray = new Button();
            btnPush = new Button();
            btnPop = new Button();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnAddFirst = new Button();
            btnAddLast = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(26, 400);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(237, 47);
            txtInput.TabIndex = 0;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.Location = new Point(280, 27);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(810, 624);
            lstDisplay.TabIndex = 1;
            // 
            // btnAddArray
            // 
            btnAddArray.Location = new Point(26, 62);
            btnAddArray.Name = "btnAddArray";
            btnAddArray.Size = new Size(94, 29);
            btnAddArray.TabIndex = 2;
            btnAddArray.Text = "Add Array";
            btnAddArray.UseVisualStyleBackColor = true;
            btnAddArray.Click += btnAddArray_Click;
            // 
            // btnShowArray
            // 
            btnShowArray.Location = new Point(149, 62);
            btnShowArray.Name = "btnShowArray";
            btnShowArray.Size = new Size(94, 29);
            btnShowArray.TabIndex = 3;
            btnShowArray.Text = "Show Array";
            btnShowArray.UseVisualStyleBackColor = true;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(26, 115);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(94, 29);
            btnPush.TabIndex = 4;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(149, 115);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(94, 29);
            btnPop.TabIndex = 5;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(26, 173);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(94, 29);
            btnEnqueue.TabIndex = 6;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(149, 173);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(94, 29);
            btnDequeue.TabIndex = 7;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            // 
            // btnAddFirst
            // 
            btnAddFirst.Location = new Point(26, 227);
            btnAddFirst.Name = "btnAddFirst";
            btnAddFirst.Size = new Size(94, 29);
            btnAddFirst.TabIndex = 8;
            btnAddFirst.Text = "Add First";
            btnAddFirst.UseVisualStyleBackColor = true;
            // 
            // btnAddLast
            // 
            btnAddLast.Location = new Point(149, 227);
            btnAddLast.Name = "btnAddLast";
            btnAddLast.Size = new Size(94, 29);
            btnAddLast.TabIndex = 9;
            btnAddLast.Text = "Add Last";
            btnAddLast.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(90, 279);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 663);
            Controls.Add(btnRemove);
            Controls.Add(btnAddLast);
            Controls.Add(btnAddFirst);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(btnShowArray);
            Controls.Add(btnAddArray);
            Controls.Add(lstDisplay);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ListBox lstDisplay;
        private Button btnAddArray;
        private Button btnShowArray;
        private Button btnPush;
        private Button btnPop;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnAddFirst;
        private Button btnAddLast;
        private Button btnRemove;
    }
}
