
using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace MS.IT.OPX.Hitachi.TiledSection.OneOverFourSection
{
    [ToolboxItemAttribute(false)]
    public class OneOverFourSection : SectionBase
    {
        #region Private fields
        private const string _Layout = "MS.IT.OPX.Hitachi.TiledSection.OneOverFourSection.LayoutOneOverFour.html";
        #endregion

        #region Constructors

        public OneOverFourSection() : base(_Layout)
        {
            Layout = Layout.OneOverFour;
            //TestConfiguration();
        }

        #endregion

        #region Private implementation
        private void TestConfiguration()
        {
            this.Configuration.SectionMode = SectionDataMode.PerTile;
            this.Configuration.SectionDataSources.Add(new StaticDataSource() { BackImageUrl = "", LinkUrl = "http://www.bing.com/", Mode = DataSourceMode.Static, Type = DataSourceType.Static, TargetTile = "tile1", Title = "Test Tile A", SubTitle = "woot!" });
            this.Configuration.SectionDataSources.Add(new StaticDataSource() { BackImageUrl = "", LinkUrl = "http://www.bing.com/", Mode = DataSourceMode.Static, Type = DataSourceType.Static, TargetTile = "tile2", Title = "Test Tile B", SubTitle = "woot!1" });
            this.Configuration.SectionDataSources.Add(new StaticDataSource() { BackImageUrl = "", LinkUrl = "http://www.bing.com/", Mode = DataSourceMode.Static, Type = DataSourceType.Static, TargetTile = "tile3", Title = "Test Tile C", SubTitle = "woot! woot!" });
            this.Configuration.SectionDataSources.Add(new StaticDataSource() { BackImageUrl = "", LinkUrl = "http://www.bing.com/", Mode = DataSourceMode.Static, Type = DataSourceType.Static, TargetTile = "tile4", Title = "Test Tile D", SubTitle = "woot! 123" });
            this.Configuration.SectionDataSources.Add(new StaticDataSource() { BackImageUrl = "", LinkUrl = "http://www.bing.com/", Mode = DataSourceMode.Static, Type = DataSourceType.Static, TargetTile = "tile5", Title = "Test Tile E", SubTitle = "woot! megrab!" });
        }

        #endregion

        #region Properties

        #endregion

        #region Public interface

        #endregion
    }
}
