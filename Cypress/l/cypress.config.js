const { defineConfig } = require("cypress");

/* This is the configuration for the Cypress Dashboard. */

module.exports = defineConfig({
  projectId: '1di7q8',
  e2e: {
    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});

/* A reporter that generates a report in the cypress/report/mochawesome-report folder. */
{
  "reporter"; "mochawesome",
  "reporterOptions"; {
  "reportDir"; "cypress/report/mochawesome-report",
  "overwrite"; true,
  "html"; true,
  "json"; false,
  "timestamp"; "mmddyyyy_HHMMss"
  }   
}
