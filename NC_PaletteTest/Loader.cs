using Teigha.Runtime;

namespace NC_PaletteTest
{
    public class Loader : IExtensionApplication
    {
        private static HostMgd.Windows.PaletteSet? ps_Demo;

        [CommandMethod("NC_SAMPLE_PALETTE_OPEN")]
        public void PaletteLoad()
        {
            if (ps_Demo == null)
            {
                ps_Demo = new HostMgd.Windows.PaletteSet("WPF Test Palette", "WPF_UserControl_Sample", new Guid("CA51059C-5347-410B-9225-43E3155C6475"));
                ps_Demo.MinimumSize = new System.Drawing.Size(200, 300);
                //target_ps.Size = new System.Drawing.Size(target_info.Size[0], target_info.Size[1]);
                ps_Demo.AddVisual("", new PaletteDemo());
            }

            ps_Demo.Visible = true;

        }
        public void Initialize()
        {

        }

        public void Terminate()
        {

        }
    }
}
