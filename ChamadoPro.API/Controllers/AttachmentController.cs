using ChamadoPro.Application.DTOs.Attachment;
using ChamadoPro.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChamadoPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly IAttachmentService _attachmentService;

        public AttachmentController(IAttachmentService attachmentService)
        {
            _attachmentService = attachmentService;
        }

        [HttpGet("ticket/{ticketId}")]
        public async Task<ActionResult<IEnumerable<AttachmentResponseDTO>>> GetAttachmentsByTicketId(int ticketId)
        {
            var attachments = await _attachmentService.GetByTicketIdAsync(ticketId);
            return Ok(attachments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttachmentResponseDTO>> GetAttachmentById(int id)
        {
            var attachment = await _attachmentService.GetByIdAsync(id);
            if (attachment == null)
                return NotFound();
            return Ok(attachment);
        }

        [HttpPost]
        public async Task<ActionResult<AttachmentResponseDTO>> CreateAttachment([FromBody] AttachmentRequestDTO attachmentRequest)
        {
            if (attachmentRequest == null)
                return BadRequest();

            var createdAttachment = await _attachmentService.CreateAsync(attachmentRequest);
            return CreatedAtAction(nameof(GetAttachmentById), new { id = createdAttachment.Id }, createdAttachment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AttachmentResponseDTO>> UpdateAttachment(int id, [FromBody] AttachmentRequestDTO attachmentRequest)
        {
            if (attachmentRequest == null)
                return BadRequest();

            var updatedAttachment = await _attachmentService.UpdateAsync(id, attachmentRequest);
            if (updatedAttachment == null)
                return NotFound();
            return Ok(updatedAttachment);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttachment(int id)
        {
            await _attachmentService.DeleteAsync(id);
            return NoContent();
        }
    }
}
