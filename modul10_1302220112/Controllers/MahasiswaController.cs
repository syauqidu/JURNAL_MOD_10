using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220112.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>()
        {
            new Mahasiswa("Syauqi Dhiya Ulhaq","1302220112", new List<string>{"PBO", "KPL", "BasDat"},2023),
            new Mahasiswa("Nicholas Xavier Robinson Silalahi","1302220078", new List<string>{"PBO", "KPL", "BasDat"}, 2023),
            new Mahasiswa("Ahmad Fadli Akbar","1302220126", new List<string>{"PBO", "KPL", "BasDat"}, 2023)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public ActionResult Post(Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            return CreatedAtAction(nameof(Get), new { id = mahasiswaList.IndexOf(mahasiswa) }, mahasiswa);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
            return NoContent();
        }
    }
}
