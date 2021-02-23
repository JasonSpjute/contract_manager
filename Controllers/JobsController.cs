namespace contract_manager.Controllers
{
    public class JobsController
    {
        [ApiController]
        [Route("api/[controller]")]
        class ModelsController : ControllerBase
        {
            private readonly ModelsService _modelsService;
            public ModelsController(ModelsService modelsService)
            {
                _modelsService = modelsService;
            }

            [HttpGet]
            public ActionResult<IEnumerable<Model>> GetAll()
            {
                try
                {
                    return Ok(_modelsService.GetAll());
                }
                catch (System.Exception err)
                {
                    return BadRequest(err.Message);
                }
            }

            [HttpGet("{id}")]
            public ActionResult<Model> GetById(int id)
            {
                try
                {
                    return Ok(_modelsService.GetById(id));
                }
                catch (System.Exception err)
                {
                    return BadRequest(err.Message);
                }
            }

            [HttpPost]
            public ActionResult<Model> Create([FromBody] Model newModel)
            {
                try
                {
                    return Ok(_modelsService.Create(newModel));
                }
                catch (System.Exception err)
                {
                    return BadRequest(err.Message);
                }
            }

            [HttpPut("{id}")]
            public ActionResult<Model> Edit(int id, [FromBody] Model editedModel)
            {
                try
                {
                    return Ok(_modelsService.Edit(id, editedModel));
                }
                catch (System.Exception err)
                {
                    return BadRequest(err.Message);
                }
            }

            [HttpDelete("{id}")]
            public ActionResult<Model> Delete(int id)
            {
                try
                {
                    return Ok(_modelsService.Delete(id));
                }
                catch (System.Exception err)
                {
                    return BadRequest(err.Message);
                }
            }
        }
    }
}