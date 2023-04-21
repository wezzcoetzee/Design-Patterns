using Bridge;

var emailSender = new EmailSender();
var smsSender = new SmsSender();
var pushNotificationSender = new PushNotificationSender();

var textMessage = new TextMessage(emailSender, "Hello, World!");
textMessage.Send();

var imageMessage = new ImageMessage(smsSender, "https://example.com/image.jpg");
imageMessage.Send();

var videoMessage = new VideoMessage(pushNotificationSender, "https://example.com/video.mp4");
videoMessage.Send();