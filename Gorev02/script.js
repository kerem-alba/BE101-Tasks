const nameInput = document.getElementById("name");
const nameHolder = document.getElementById("name-holder");
const defaultNameText = nameHolder.textContent;

const titleInput = document.getElementById("title");
const titleHolder = document.getElementById("title-holder");
const defaultTitleText = titleHolder.textContent;

const aboutMeInput = document.getElementById("about-me");
const aboutMeHolder = document.getElementById("about-me-holder");
const defaultAboutMeText = aboutMeHolder.textContent;

const phoneInput = document.getElementById("phone");
const phoneHolder = document.getElementById("phone-holder");
const defaultPhoneText = phoneHolder.textContent;

const emailInput = document.getElementById("email");
const emailHolder = document.getElementById("email-holder");
const defaultEmailText = emailHolder.textContent;

const webInput = document.getElementById("web");
const webHolder = document.getElementById("web-holder");
const defaultWebText = webHolder.textContent;

const addressInput = document.getElementById("address");
const addressHolder = document.getElementById("address-holder");
const defaultAddressText = addressHolder.textContent;

const skillsInput = document.getElementById("skills-description");
const skillsHolder = document.getElementById("skills-description-area");
const defaultSkillsText = skillsHolder.textContent;

const schoolsInput = document.getElementById("school-description");
const schoolsHolder = document.getElementById("schools-description-area");
const defaultSchoolsText = schoolsHolder.textContent;


const workExperienceInput = document.getElementById("work-experience");
const workExperienceHolder = document.getElementById("experience-holder");
const defaultWorkExperienceText = workExperienceHolder.textContent;


nameInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(nameInput, nameHolder, defaultNameText);
});
titleInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(titleInput, titleHolder, defaultTitleText);
});
aboutMeInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(aboutMeInput, aboutMeHolder, defaultAboutMeText);
});

phoneInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(phoneInput, phoneHolder, defaultPhoneText);
});

emailInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(emailInput, emailHolder, defaultEmailText);
});
webInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(webInput, webHolder, defaultWebText);
});

addressInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(addressInput, addressHolder, defaultAddressText); 
});

workExperienceInput.addEventListener("input", function () {
	clearDefaultTexts();
	update(workExperienceInput, workExperienceHolder, defaultWorkExperienceText);
});


function update(input, holder, defText) {
	if (input.value === "") {
		holder.textContent = defText;
	} else {
		holder.textContent = input.value;
	}
}


const holders = [nameHolder, titleHolder, aboutMeHolder, phoneHolder, emailHolder, webHolder,addressHolder, workExperienceHolder, skillsHolder, schoolsHolder];
const inputs = [nameInput, titleInput, aboutMeInput, phoneInput, emailInput, webInput, addressInput, workExperienceInput, skillsInput, schoolsInput];

let isDefaultTextCleared = false;
function clearDefaultTexts() {
	if (!isDefaultTextCleared) {
		holders.forEach(function (holder) {
			holder.textContent = "";
		});
		isDefaultTextCleared = true;
	}
}




const schoolCountSelect = document.getElementById("school-count");
const schoolInputsContainer = document.getElementById("school-inputs-container");
const schoolsList = document.getElementById("schools-list");
const schoolsDescriptionInput = document.getElementById("school-description");
const schoolsDescriptionArea = document.getElementById("schools-description-area");

function updateSchoolDescription() {
	schoolsDescriptionArea.textContent = schoolsDescriptionInput.value;
}

schoolsDescriptionInput.addEventListener("input", updateSchoolDescription);
function updateSchoolsList() {
	schoolsList.innerHTML = '';

	for (var i = 1; i <= schoolCountSelect.value; i++) {
		const schoolNameInput = document.getElementById("school-name" + i );
		const schoolDescInput = document.getElementById("school-desc" + i);

		const schoolName = schoolNameInput.value;
		const schoolDesc = schoolDescInput.value;

		if (schoolName) {
			const li = document.createElement("li");
			li.textContent = schoolName;

			if (schoolDesc) {
				const subLi = document.createElement("li");
				subLi.textContent = schoolDesc;
				subLi.style.listStyleType = "circle"; 
				subLi.style.marginLeft = "30px";
				li.appendChild(subLi);
			}
			schoolsList.appendChild(li);
		}
	}
}

schoolCountSelect.addEventListener("change", function () {
	const inputsTable = document.createElement("table");
	schoolInputsContainer.innerHTML = '';

	for (var i = 1; i <= schoolCountSelect.value; i++) {
		const row = inputsTable.insertRow();

		const cell1 = row.insertCell(0);
		cell1.textContent = "Okul-" + i + ": ";
		cell1.style.width = "50%";

		const cell2 = row.insertCell(1);
		const schoolNameInput = document.createElement("input");
		schoolNameInput.type = "text";
		schoolNameInput.id = "school-name" + i;
		cell2.appendChild(schoolNameInput);
		cell2.style.width = "25%";

		const cell3 = row.insertCell(2);
		const schoolDescInput = document.createElement("input");
		schoolDescInput.type = "text";
		schoolDescInput.id = "school-desc" + i;
		schoolDescInput.placeholder = "Açýklama";
		cell3.appendChild(schoolDescInput);
		cell2.style.width = "25%";

		schoolNameInput.addEventListener("input", updateSchoolsList);
		schoolDescInput.addEventListener("input", updateSchoolsList);
	}

	schoolInputsContainer.appendChild(inputsTable);
});


const skillsCountSelect = document.getElementById("skills-count");
const skillsInputsContainer = document.getElementById("skills-inputs-container");
const skillsList = document.getElementById("skills-list"); 
const skillsDescriptionInput = document.getElementById("skills-description");
const skillsDescriptionArea = document.getElementById("skills-description-area");

skillsDescriptionInput.addEventListener("input", updateSkillsDescription);
function updateSkillsDescription() {
	skillsDescriptionArea.textContent = skillsDescriptionInput.value;
}
function updateSkillsList() {
	skillsList.innerHTML = ''; 

	for (var i = 1; i <= skillsCountSelect.value; i++) {
		const skillNameInput = document.getElementById("skill-name" + i);
		const skillDescInput = document.getElementById("skill-desc" + i);

		const skillName = skillNameInput.value;
		const skillDesc = skillDescInput.value;

		if (skillName) {
			const li = document.createElement("li");
			li.textContent = skillName;

			if (skillDesc) {
				const subLi = document.createElement("li");
				subLi.textContent = skillDesc;
				subLi.style.listStyleType = "circle";
				subLi.style.marginLeft = "30px";
				li.appendChild(subLi);
			}

			skillsList.appendChild(li);
		}
	}
}

skillsCountSelect.addEventListener("change", function () {
	const inputsTable = document.createElement("table");
	skillsInputsContainer.innerHTML = '';

	for (var i = 1; i <= skillsCountSelect.value; i++) {
		const row = inputsTable.insertRow();

		const cell1 = row.insertCell(0);
		cell1.textContent = "Yetenek-" + i + ": ";

		const cell2 = row.insertCell(1);
		const skillNameInput = document.createElement("input");
		skillNameInput.type = "text";
		skillNameInput.id = "skill-name" + i;
		cell2.appendChild(skillNameInput);

		const cell3 = row.insertCell(2);
		const skillDescInput = document.createElement("input");
		skillDescInput.type = "text";
		skillDescInput.id = "skill-desc" + i;
		skillDescInput.placeholder = "Açýklama";
		cell3.appendChild(skillDescInput);

		skillNameInput.addEventListener("input", updateSkillsList);
		skillDescInput.addEventListener("input", updateSkillsList);
	}

	skillsInputsContainer.appendChild(inputsTable);
});

document.getElementById('bg-color').addEventListener('input', function() {
    document.getElementById('block3').style.backgroundColor = this.value;
});

document.getElementById('left-column-color').addEventListener('input', function() {
    document.getElementById('left-subblock').style.backgroundColor = this.value;
});

document.getElementById('name-box-color').addEventListener('input', function() {
    document.getElementById('name-title-area').style.backgroundColor = this.value;
});

document.getElementById('name-box-text-color').addEventListener('input', function() {
    document.getElementById('name-title-area').style.color = this.value;
});

document.getElementById('font-family').addEventListener('change', function() {
    document.getElementById('block3').style.fontFamily = this.value;
});

document.getElementById('frame-style').addEventListener('change', function() {
    var photoArea = document.getElementById('photo-area');


    if (this.value === 'square') {
        photoArea.style.borderRadius = '0';
    } else if (this.value === 'rounded') {
        photoArea.style.borderRadius = '40px';
    } else if (this.value === 'circle') {
        photoArea.style.borderRadius = '50%';
    }
});

document.getElementById('underline-color').addEventListener('input', function() {
    updateUnderlineStyle();
});

document.getElementById('underline-style').addEventListener('change', function() {
    updateUnderlineStyle();
});

function updateUnderlineStyle() {
    const color = document.getElementById('underline-color').value;
    const style = document.getElementById('underline-style').value;
    const headers = document.querySelectorAll('.block3-header h2');

    headers.forEach(function(header) {
        header.style.borderBottom = `4px ${style} ${color}`;
    });
}