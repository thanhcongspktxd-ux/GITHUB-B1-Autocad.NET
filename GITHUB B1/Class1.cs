using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Internal;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Runtime.ConstrainedExecution;


namespace GITHUB_B1
{
    public class GitHubB1
    {
        [CommandMethod("HELLO GITHUB")]
        public void SayHello()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
           
            ed.WriteMessage("\nHello GitHub. NET Updated 234");
        }
    }
}
