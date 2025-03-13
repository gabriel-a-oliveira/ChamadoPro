using Microsoft.AspNetCore.Mvc;
using ChamadoPro.Application.DTOs.Ticket;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Enums;

namespace ChamadoPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TicketResponseDTO>> GetTicketById(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null)
                return NotFound();
            return Ok(ticket);
        }

        [HttpGet("user/{userId:int}")]
        public async Task<ActionResult<IEnumerable<TicketResponseDTO>>> GetTicketsByUserId(int userId)
        {
            var tickets = await _ticketService.GetTicketsByUserIdAsync(userId);
            return Ok(tickets);
        }

        [HttpGet("responsible/{responsibleId:int}")]
        public async Task<ActionResult<IEnumerable<TicketResponseDTO>>> GetTicketsByResponsible(int responsibleId)
        {
            var tickets = await _ticketService.GetTicketsByResponsibleAsync(responsibleId);
            return Ok(tickets);
        }

        [HttpGet("status/{status}")]
        public async Task<ActionResult<IEnumerable<TicketResponseDTO>>> GetTicketsByStatus(string status)
        {
            if (!Enum.TryParse<Status>(status, true, out var parsedStatus))
                return BadRequest("Invalid status value.");

            var tickets = await _ticketService.GetTicketsByStatusAsync(parsedStatus);
            return Ok(tickets);
        }

        [HttpGet("priority/{priority}")]
        public async Task<ActionResult<IEnumerable<TicketResponseDTO>>> GetTicketsByPriority(string priority)
        {
            if (!Enum.TryParse<Priority>(priority, true, out var parsedPriority))
                return BadRequest("Invalid priority value.");

            var tickets = await _ticketService.GetTicketsByPriorityAsync(parsedPriority);
            return Ok(tickets);
        }

        [HttpGet("category/{categoryId:int}")]
        public async Task<ActionResult<IEnumerable<TicketResponseDTO>>> GetTicketsByCategory(int categoryId)
        {
            var tickets = await _ticketService.GetTicketsByCategoryAsync(categoryId);
            return Ok(tickets);
        }

        [HttpGet("completed/{dateTime}")]
        public async Task<ActionResult<IEnumerable<TicketResponseDTO>>> GetTicketsByCompleted(string dateTime)
        {
            if (!DateTime.TryParse(dateTime, out var parsedDateTime))
                return BadRequest("Invalid dateTime value.");

            var tickets = await _ticketService.GetTicketsByCompletedAsync(parsedDateTime);
            return Ok(tickets);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketResponseDTO>>> GetAllTickets()
        {
            var tickets = await _ticketService.GetAllTicketsAsync();
            return Ok(tickets);
        }

        [HttpPost]
        public async Task<ActionResult<TicketResponseDTO>> CreateTicket([FromBody] TicketRequestDTO ticketRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdTicket = await _ticketService.CreateTicketAsync(ticketRequest);
            return CreatedAtAction(nameof(GetTicketById), new { id = createdTicket.Id }, createdTicket);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<TicketResponseDTO>> UpdateTicket(int id, [FromBody] TicketRequestDTO ticketRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedTicket = await _ticketService.UpdateTicketAsync(id, ticketRequest);
            if (updatedTicket == null)
                return NotFound();

            return Ok(updatedTicket);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            await _ticketService.DeleteTicketAsync(id);
            return NoContent();
        }
    }
}
