using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        public static List<Article> _articles = new List<Article>();


        // 1- Makaleleri Listeleme
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Article>))]
        public IActionResult GetArticles()
        {
            return Ok(_articles);
        }


        // 2- Makale Detayını Getirme 

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Article>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]

        public IActionResult GetArticleById(int id)
        {
            var theArticle = _articles.Find(x => x.Id == id);

            if (theArticle == null)
            {
                return NotFound("The article with this id is not found");
            }
            return Ok(theArticle);
        }

        // 3- Makale Ekleme

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Article))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [Consumes("application/json")]
        public IActionResult CreateArticle([FromBody] Article article)
        {
            if (string.IsNullOrWhiteSpace(article.Title))
            {
                return BadRequest("Article title cannot be empty or null.");
            }
            article.Id = _articles.Count + 1;
            _articles.Add(article);

            return CreatedAtAction(nameof(GetArticleById), new { id = article.Id }, article);
        }

        // 4- Makale Güncelleme

        [HttpPut("{id}")]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Article>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public IActionResult UpdateArticle(int id, [FromBody] Article articleUpdate)
        {
            if (string.IsNullOrWhiteSpace(articleUpdate.Title))
            {
                return BadRequest("Article title cannot be empty or null.");
            }

            var article = _articles.Find(a => a.Id == id);
            if (article == null)
            {
                return NoContent();
            }

            article.Title = articleUpdate.Title;
            article.Content = articleUpdate.Content;

            return Ok(article);
        }

        // 5- Makale Silme

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Article>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteArticle(int id)
        {
            var article = _articles.Find(a => a.Id == id);
            if (article == null)
            {
                return NoContent();
            }

            _articles.Remove(article);
            return Ok("The article is removed.");
        }
    }
}
