using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace DoConnect.Api.Dtos
{
     // DTO used when creating a new answer.
    public class AnswerCreateDto
    {
        // The actual text content of the answer.
        // Required and limited to a maximum of 4000 characters.
        [Required, MaxLength(4000)] public string Text { get; set; } = default!;
        public List<IFormFile>? Files { get; set; }
    }

   // DTO used to return an answer in API responses.
    public class AnswerOutDto
    {
        // Unique identifier of the answer
        public Guid Id { get; set; }

        // The text content of the answer.
        public string Text { get; set; } = default!;

        // The username or display name of the answer's author.
        public string Author { get; set; } = default!;

        // The current status of the answer (e.g., "Pending", "Approved", "Rejected").
        public string Status { get; set; } = default!;

        //The date and time when the answer was created.
        public DateTime CreatedAt { get; set; }
        
        // A list of URLs or file paths pointing to images associated with the answer.
        public List<string> Images { get; set; } = new();
    }
}
