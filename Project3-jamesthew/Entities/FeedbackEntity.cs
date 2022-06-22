using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3_jamesthew.Entitites
{
    public class FeedbackEntity
    {
        [Key]
        public int FeedbackId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string FeedbackName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string FeedbackEmail { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string FeedbackReview { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Subject { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Details { get; set; }


        public FeedbackEntity(int feedbackId, string feedbackName, string feedbackEmail, string feedbackReview, string phoneNumber, string subject, string details)
        {
            FeedbackId = feedbackId;
            FeedbackName = feedbackName;
            FeedbackEmail = feedbackEmail;
            FeedbackReview = feedbackReview;
            PhoneNumber = phoneNumber;
            Subject = subject;
            Details = details;
        }

        public FeedbackEntity()
        {
            
        }
    }
}
