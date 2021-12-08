$(document).ready(() => {

	let submit = $('button.submit');
	let input = $('input');
	let formContainer = $('div.form-container');

	function validateForm() {
		let invalidFields = 0;
		for (let i = 0; i < input.length; i++) {
			if (input.eq(i).val() === '') {
				input.eq(i).addClass('error');
				invalidFields++;
			} else {
				input.eq(i).removeClass('error');
			}
		}
		if (invalidFields > 0) {
			submit.addClass('disabled');
			return false;
		} else {
			submit.removeClass('disabled');
			return true;
		}
	}

	function getCursorPos(e) {
		var relativeX = (e.pageX - submit.offset().left);
		var relativeY = (e.pageY - submit.offset().top);
		return [relativeX, relativeY];
	}

	formContainer.on('mousemove', (e) => {
		let submitHeight = submit.innerHeight();
		let mousePos = getCursorPos(e);

		if (mousePos[1] > -80 && mousePos[1] < (submitHeight + 50)) {
			validateForm();
		}

	});

	submit.on('click', (e) => {
		e.preventDefault();
		let validated = validateForm();
		if (validated) {
			formContainer.addClass('applied');
		}
	});

});