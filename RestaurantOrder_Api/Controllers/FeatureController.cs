using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.FeatureDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetAllList());
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            Feature Feature = new Feature()
            {
                Description1 = createFeatureDto.Description1,
                Description2 = createFeatureDto.Description2,
                Description3 = createFeatureDto.Description3,
                Title1 = createFeatureDto.Title1,
                Title2 = createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3,

            };
            _featureService.TAdd(Feature);
            return Ok("eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            Feature Feature = new Feature()
            {
                FeatureID = updateFeatureDto.FeatureID,
                Description1 = updateFeatureDto.Description1,
                Description2 = updateFeatureDto.Description2,
                Description3 = updateFeatureDto.Description3,
                Title1 = updateFeatureDto.Title1,
                Title2 = updateFeatureDto.Title2,
                Title3 = updateFeatureDto.Title3,

            };
            _featureService.TUpdate(Feature);
            return Ok("güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }
    }
}
