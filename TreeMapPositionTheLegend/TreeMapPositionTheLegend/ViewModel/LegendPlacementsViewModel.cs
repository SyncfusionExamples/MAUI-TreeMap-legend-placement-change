using System.Collections.ObjectModel;

namespace TreeMapPositionTheLegend
{
    /// <summary>
    /// Represents the view model for the legend placements functionality.
    /// </summary>
    public class LegendPlacementsViewModel
    {
        /// <summary>
        /// Gets or sets the collection of legend placements details.
        /// </summary>
        public ObservableCollection<LegendPlacements> LegendPlacement { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegendPlacementsViewModel"/> class.
        /// </summary>
        public LegendPlacementsViewModel()
        {
            this.LegendPlacement = new ObservableCollection<LegendPlacements>();
            this.LegendPlacement.Add(new LegendPlacements() { PlaceName = "Top" });
            this.LegendPlacement.Add(new LegendPlacements() { PlaceName = "Bottom" });
        }
    }
}
