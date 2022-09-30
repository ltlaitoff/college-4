export function htmlStringToElement(html) {
	const template = document.createElement('template')

	html = html.trim()
	template.innerHTML = html

	return template.content.firstElementChild
}
