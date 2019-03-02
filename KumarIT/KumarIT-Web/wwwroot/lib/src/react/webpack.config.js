const path = require('path');
const webpack = require('webpack');

module.exports = {
    mode: "development",
    watch: true,
    context: __dirname,
    entry: "./app",
    output:
    {
        path: path.resolve(__dirname, 'build'),
        filename: 'bundle.js'
    },
 
    module: {
        rules: [
            {
            test: /\.js$/,
                exclude: /(node_modules)/,
                query: { presets: ['@babel/preset-env', '@babel/preset-react'] },
        use: {
            loader: 'babel-loader',
            filename: 'bundle.js',
            path: path.resolve(__dirname, 'dist'),
            options: {
                presents: ['babel-present-env', 'babel-present-react']
            }
        }
    }
            ]
    }
}