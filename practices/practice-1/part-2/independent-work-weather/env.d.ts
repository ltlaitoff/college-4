/// <reference types="vite/client" />

interface ImportMetaEnv {
  readonly VITE_APP_TITLE: string
  readonly VITE_API_KEY: string
  readonly VITE_API_CURRENT_WEATHER_HOST: string
}

interface ImportMeta {
  readonly env: ImportMetaEnv
}
