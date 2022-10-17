/// <binding BeforeBuild='develop' />
var ts = require('gulp-typescript');
var gulp = require('gulp');
var clean = require('gulp-clean');
var concat = require("gulp-concat");
var uglify = require("gulp-uglify");

var destPath = './wwwroot/js/';

// Delete the dist directory
gulp.task('clean', function () {
    return gulp.src([destPath], { allowEmpty: true })
        .pipe(clean());
}); 

var tsProject = ts.createProject('tsconfig.json');
gulp.task('ts', function (done) { 
    var tsResult = gulp.src([
        "main.ts"
    ])
        .pipe(ts(tsProject), undefined, ts.reporter.fullReporter());
    return tsResult.js.pipe(gulp.dest('./'));
});

gulp.task("min-js", function () {
    return gulp.src([destPath + 'webzor.js'], { base: "." })
        .pipe(concat(destPath + 'webzor.min.js'))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task('develop', gulp.series('clean', 'ts', 'min-js'));

gulp.task('watch', function () {
    gulp.watch('main.js', gulp.series(['develop']))
});

