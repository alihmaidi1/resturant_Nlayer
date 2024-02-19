using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderProject.BussinessLayer.Abstract;
using RestaurantOrderProject.DtoLayer.CategoryDtos;
using RestaurantOrderProject.DtoLayer.ContactDtos;
using RestaurantOrderProject.EntityLayer.Entities;

namespace RestaurantOrder_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _mapper.Map<List<ResultContactDto>>(_contactService.TGetAllList());
            return Ok(values);

        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact Contact = new Contact()
            {
               FooterDescription = createContactDto.FooterDescription,
               Location = createContactDto.Location,
               Mail = createContactDto.Mail,
               Phone = createContactDto.Phone,
               

            };
            _contactService.TAdd(Contact);
            return Ok("eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("silindi");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact Contact = new Contact()
            {
                FooterDescription = updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                Phone = updateContactDto.Phone,
                ContactID = updateContactDto.ContactID

            };
            _contactService.TUpdate(Contact);
            return Ok("güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
    }
}
