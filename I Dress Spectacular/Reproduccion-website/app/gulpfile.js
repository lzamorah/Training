var gulp = require('gulp');
var compass= require('gulp-compass')

gulp.task('compass', function () {
	gulp.src('scss/*.scss')
        .pipe(compass({
        	css: 'css',
      		sass: 'scss',
      		image: 'images'}))
        .pipe(gulp.dest('css'));
});

gulp.watch(['scss/*.scss'], ['compass']);


gulp.task('default', ['compass', 'watch']);