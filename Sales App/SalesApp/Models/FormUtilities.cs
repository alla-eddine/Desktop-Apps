using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public static class FormUtilities
{
    /// <summary>
    /// Refreshes the DataGridView with the specified data source.
    /// </summary>
    /// <param name="dataGridView">The DataGridView to refresh.</param>
    /// <param name="dataSource">The data source to bind to the DataGridView.</param>
    public static void RefreshDataGrid(DataGridView dataGridView, DataTable dataSource, string ID)
    {
        dataGridView.DataSource = dataSource;
        dataGridView.Columns[ID].Visible = false;
        dataGridView.Refresh();
        dataGridView.ClearSelection();  
    }

    /// <summary>
    /// Clears all TextBox controls in the specified form or container.
    /// </summary>
    /// <param name="container">The container holding the controls to clear.</param>
    public static void ClearFields(Control container)
    {
        foreach (Control control in container.Controls)
        {
            if (control is TextBox textBox)
            {
                textBox.Clear();
            }
            else if (control.HasChildren)
            {
                ClearFields(control); // Recursively clear nested controls
            }
        }
    }

    public static byte[] ConvertImageToByteArray(Image image)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, image.RawFormat); // Save the image in its original format
            return ms.ToArray(); // Convert the MemoryStream to a byte array
        }
    }
}
