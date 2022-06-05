using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebProje.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        [BindProperty]
        public IFormFile personImage { get; set; }  
  
        [BindProperty]
        public String personName { get; set; }

        [BindProperty]
        public String personSurname { get; set; }

        [BindProperty]
        public DateTime personBdate { get; set; }

        [BindProperty]
        public int personsex { get; set; }

        [BindProperty]
        public  int city { get; set; }

        public String message { get; set; }


        public void OnGet()
        {

        }

        public void OnPost()
        {
        String[] citiesList = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "İçel (Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
        String[] sexList = { "Male", "Female" };
        var age = DateTime.Today.Year - personBdate.Year;
        message = String.Format("Welcome {0} {1}. Your age is {2}. Your sex is {3}. You live in {4}", personName, personSurname, age, sexList[personsex-1], citiesList[city-1]);
        }
    }
}