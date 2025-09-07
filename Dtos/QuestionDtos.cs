using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace DoConnect.Api.Dtos
{
    // DTO for creating a new question (input from client to API).
    public class QuestionCreateDto
    {
        // The title of the question.
        // Required, maximum length of 140 characters.
        [Required, MaxLength(140)]
        public string Title { get; set; } = default!;

        //The detailed description or body of the question.
        // Required, maximum length of 4000 characters.
        [Required, MaxLength(4000)]
        public string Text { get; set; } = default!;

        // Optional file attachments (e.g., images, documents) uploaded with the question.
        public List<IFormFile>? Files { get; set; }
    }


    // DTO for returning question details in API responses.
    public class QuestionOutDto
    {
        // Unique identifier of the question (GUID).
        public Guid Id { get; set; }

        // The title of the question.
        public string Title { get; set; } = default!;

        // The detailed body of the question.
        public string Text { get; set; } = default!;

        // The username or display name of the person who asked the question.
        public string Author { get; set; } = default!;

        // The current status of the question (e.g., "Open", "Closed", "Pending").
        public string Status { get; set; } = default!;

        // The date and time when the question was created.
        public DateTime CreatedAt { get; set; }

        // A list of URLs or file paths for images attached to the question.
        
        public List<string> Images { get; set; } = new();
    }
}
