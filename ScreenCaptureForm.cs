using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;

namespace AiCompanion
{

    public class ScreenCaptureForm : Form
    {
        private Point startPoint;        // Start point of the selection
        private Rectangle selectionRect; // The region selected by the user
        private bool isSelecting = false; // Whether the user is currently selecting
        private Bitmap capturedImage;

        public ScreenCaptureForm()
        {
            // Set form properties to make it cover the entire virtual screen (all monitors)
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            //this.MinimumSize = new Size(1, 1); // Allow any size initially
            //this.MaximumSize = Screen.PrimaryScreen.Bounds.Size; // Expandable if necessary
            this.Bounds = GetVirtualScreenBounds();
            this.TopMost = true;
            this.Opacity = 0.5; // Set transparency
            this.BackColor = Color.Gray;
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Cross; // Set cursor to a cross for region selection

            // Make the form listen to key events
            this.KeyPreview = true;  // Important: allows the form to capture key presses
            this.KeyDown += new KeyEventHandler(ScreenCaptureForm_KeyDown);

            // Mouse event handlers for selection
            this.MouseDown += new MouseEventHandler(ScreenCaptureForm_MouseDown);
            this.MouseMove += new MouseEventHandler(ScreenCaptureForm_MouseMove);
            this.MouseUp += new MouseEventHandler(ScreenCaptureForm_MouseUp);
        }
        
        private void ScreenCaptureForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;

            this.Bounds = GetVirtualScreenBounds();
        }
        private Rectangle GetVirtualScreenBounds()
        {
            int left = int.MaxValue;
            int top = int.MaxValue;
            int right = int.MinValue;
            int bottom = int.MinValue;

            foreach (Screen screen in Screen.AllScreens)
            {
                left = Math.Min(left, screen.Bounds.Left);
                top = Math.Min(top, screen.Bounds.Top);
                right = Math.Max(right, screen.Bounds.Right);
                bottom = Math.Max(bottom, screen.Bounds.Bottom);
                Debug.WriteLine($"Screen: {screen.DeviceName}, Bounds: {screen.Bounds}");

            }

            return new Rectangle(left, top, right - left, bottom - top);
        }

        private void ScreenCaptureForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Start selecting the region
            if (e.Button == MouseButtons.Left)
            {
                isSelecting = true;
                startPoint = e.Location;
            }
        }

        private void ScreenCaptureForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Update the rectangle size as the user moves the mouse
            if (isSelecting)
            {
                selectionRect = new Rectangle(
                    Math.Min(startPoint.X, e.X),
                    Math.Min(startPoint.Y, e.Y),
                    Math.Abs(startPoint.X - e.X),
                    Math.Abs(startPoint.Y - e.Y));

                // Redraw the form to show the updated rectangle
                this.Invalidate();
            }
        }

        private void ScreenCaptureForm_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop selecting and capture the screenshot
            if (isSelecting)
            {
                isSelecting = false;
                if (CaptureSelectedRegion())
                    this.DialogResult = DialogResult.OK; // Set the dialog result to OK
                else
                    this.DialogResult = DialogResult.Cancel; // Set the dialog result to cancel
                this.Close(); // Close the form after capturing the region
            }
        }

        private void ScreenCaptureForm_KeyDown(object sender, KeyEventArgs e)
        {
            // If the Esc key is pressed, cancel the form
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel; // Set dialog result to Cancel
                this.Close(); // Close the form
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the selection rectangle on the screen
            if (isSelecting)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen, selectionRect);
                }
            }
        }

        private bool CaptureSelectedRegion()
        {
            if (selectionRect.Width > 0 && selectionRect.Height > 0)
            {
                // Capture the selected region as a screenshot
                capturedImage = new Bitmap(selectionRect.Width, selectionRect.Height);
                using (Graphics g = Graphics.FromImage(capturedImage))
                {
                    g.CopyFromScreen(selectionRect.Location, Point.Empty, selectionRect.Size);
                }
                return true;
            }
            return false;
        }

        public Bitmap GetCapturedImage()
        {
            return capturedImage;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScreenCaptureForm());
        }
    }

}
