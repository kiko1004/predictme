using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PredictMeML.Model;

namespace PredictMe.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public int Fage { get; set; }
        [BindProperty]
        public int Frank { get; set; }
        [BindProperty]
        public int Sage { get; set; }
        [BindProperty]
        public int Srank { get; set; }

        public double Result { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            var input = new ModelInput();
            input.F_boxer_age = Fage;
            input.F_boxer_ranking = Frank;
            input.S_boxer_ranking = Sage;
            input.S_boxer_age = Srank;
               
            ModelOutput result = ConsumeModel.Predict(input);
            Result = result.Score;
            
        }
    }
}
