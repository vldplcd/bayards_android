using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bayards_Safety_App
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RisksCarousel : CarouselPage
    {
        List<RiskDetails> _risks;
        public RisksCarousel(List<RiskDetails> risks, string riskId, string title)
        {
			InitializeComponent ();
            _risks = risks;

            foreach (var risk in _risks)
            {
                Children.Add(risk);
            }
            CurrentPage = Children.FirstOrDefault(x => ((RiskDetails)x).RiskId == riskId);
            Title = title;
        }

    }
}
