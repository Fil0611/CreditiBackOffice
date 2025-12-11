namespace Common.Utility {
    public class TextFieldUtilities {
        public static async void FlashBackground (DevExpress.XtraEditors.TextEdit textEdit) {
            Color originalColor = textEdit.BackColor;

            for (int i = 0; i < 3; i++) {
                textEdit.BackColor = Color.Red;
                await Task.Delay(200);
                textEdit.BackColor = originalColor;
                await Task.Delay(200);
            }

            textEdit.Focus();
        }
    }
}
