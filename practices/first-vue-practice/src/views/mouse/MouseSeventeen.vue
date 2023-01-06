<script setup>
import { ref } from 'vue'
const DEFAULT_SIZE = 500
const ZOOM_SIZE = DEFAULT_SIZE * 1.4

const x = ref(0)
const y = ref(0)
const mouseInRect = ref(0)

const getMousePositionInRect = (rect, e) => {
	const x = e.clientX - rect.left
	const y = e.clientY - rect.top

	return [x, y]
}

function onMouseMove(e) {
	const rect = e.target.getBoundingClientRect()
	const [xNew, yNew] = getMousePositionInRect(rect, e)

	x.value = xNew
	y.value = yNew
}

function onMouseLeave(e) {
	const target = e.target

	target.style.width = `${DEFAULT_SIZE}px`
	target.style.height = `${DEFAULT_SIZE}px`

	mouseInRect.value = false
}

function onMouseEnter(e) {
	const target = e.target

	target.style.width = `${ZOOM_SIZE}px`
	target.style.height = `${ZOOM_SIZE}px`

	mouseInRect.value = true
}
</script>

<template>
	<div
		:class="$style.block"
		@mousemove="onMouseMove"
		@mouseleave="onMouseLeave"
		@mouseenter="onMouseEnter"
	></div>
	<div :class="$style.coords">
		<span :class="[$style.coord, !mouseInRect && $style.leave]">
			X = {{ x }};
		</span>
		<span :class="[$style.coord, !mouseInRect && $style.leave]">
			Y = {{ y }}
		</span>
	</div>
</template>

<style src="../../style/mouse/MouseSeventeen.scss" module></style>
