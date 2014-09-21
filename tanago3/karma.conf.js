module.exports = function (config) {
	config.set({

		// base path, that will be used to resolve files and exclude
		basePath: '',

		frameworks: ['jasmine'],
		files: [
			'app/js/**/*.js',
			'test/js/**/*.js'
		],
		exclude: [
			'**/*.swp'
		],

		// test results reporter to use
		// possible values: 'dots', 'progress', 'junit', 'growl', 'coverage'
		//reporters: ['progress', 'junit', 'coverage'],
		reporters: ['progress'],

		junitReporter: {
		outputFile: 'reports/junit/test-results.xml',
		suite: ''
		},

		preprocessors: {
			'app/js/**/*.js': ['coverage']
		},
		coverageReporter: {
			type: 'cobertura',
			dir: 'reports/coverage/',
			file: 'coverage.xml'
		},
		port: 9875,
		colors: true,
		logLevel: config.LOG_DEBUG,
		autoWatch: true,
		captureTimeout: 3000,
		singleRun: false,

		// Start these browsers, currently available:
		// - Chrome
		// - ChromeCanary
		// - Firefox
		// - Opera
		// - Safari (only Mac)
		// - PhantomJS
		// - IE (only Windows)
		browsers: ['PhantomJS']
	});
};

