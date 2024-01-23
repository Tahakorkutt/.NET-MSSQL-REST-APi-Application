namespace SignalWebUI.Dtos.MailDtos
{
	public class CreateMailDto
	{
		public string ReceiverMail { get; set; } // alıcı e posta
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}
