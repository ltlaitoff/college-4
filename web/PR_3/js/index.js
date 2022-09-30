import { firstTask } from './firstTask.js'
import { secondTask } from './secondTask.js'

const APP = document.querySelector('#app')
APP.append(firstTask())
APP.append(secondTask())
