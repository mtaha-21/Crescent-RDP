//index.js  
function sendEmail() {
	Email.send({
		SecureToken:"b19cef7e-bedf-49a3-98ef-3af8b62c743e",
		To: 'samronald17@gmail.com',
		From: "winspsw2001@gmail.com",
		Subject: "Testing",
		Body:"HI",
	}).then(
		message => alert("mail sent successfully")
	);
}