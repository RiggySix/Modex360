using System;

namespace Modex360
{
    // Common contract shared by PackageEditors.EditorControl (file/package-based editors)
    // and RealtimeEditors.RealtimeEditorControl (live-console editors), so FormHandle can
    // track and close either kind of editor form without caring which one it is.
    internal interface IEditorControl
    {
        void initiateForm(int x);

        // Satisfied implicitly by Form.Close() in both concrete base classes.
        void Close();
    }
}
