namespace Estructuras_Lineales
{
    public partial class Form1 : Form
    {
        // Estructuras lineales
        private int[] array = new int[10];
        private int arrayIndex = 0;

        private Stack<int> stack = new Stack<int>();
        private Queue<int> queue = new Queue<int>();
        private LinkedList<int> linkedList = new LinkedList<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddArray_Click(object sender, EventArgs e)
        {
            if (arrayIndex < array.Length && int.TryParse(txtInput.Text, out int value))
            {
                array[arrayIndex++] = value;
                MessageBox.Show("Value added to the array.");
            }
            else
            {
                MessageBox.Show("Array is full or input is invalid.");
            }
        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            for (int i = 0; i < arrayIndex; i++)
            {
                lstDisplay.Items.Add(array[i]);
            }
        }

        // Operaciones con Pilas
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                stack.Push(value);
                MessageBox.Show("Value pushed to the stack.");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                int popped = stack.Pop();
                MessageBox.Show($"Popped: {popped}");
            }
            else
            {
                MessageBox.Show("Stack is empty.");
            }
        }

        // Operaciones con Colas
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                queue.Enqueue(value);
                MessageBox.Show("Value enqueued.");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                int dequeued = queue.Dequeue();
                MessageBox.Show($"Dequeued: {dequeued}");
            }
            else
            {
                MessageBox.Show("Queue is empty.");
            }
        }

        // Operaciones con Listas Enlazadas
        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                linkedList.AddFirst(value);
                MessageBox.Show("Value added at the beginning of the linked list.");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                linkedList.AddLast(value);
                MessageBox.Show("Value added at the end of the linked list.");
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                if (linkedList.Remove(value))
                {
                    MessageBox.Show("Value removed from the linked list.");
                }
                else
                {
                    MessageBox.Show("Value not found in the linked list.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        // Actualizar visualización de la estructura seleccionada
        private void btnShowLinkedList_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            foreach (var item in linkedList)
            {
                lstDisplay.Items.Add(item);
            }
        }
    }
    
}

