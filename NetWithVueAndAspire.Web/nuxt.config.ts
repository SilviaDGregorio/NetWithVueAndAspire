// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  compatibilityDate: '2025-07-15',
  devtools: { enabled: true },
  $development: {
    routeRules: {
      '/api/**': {
        proxy: `${import.meta.env.ApiUrl}/**`,
      }
    }
  }
})
