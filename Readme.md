# Folder Crawler

> _Developed by_  
> Rifqi Naufal Abdjul - 13520062  
> Malik Akbar Hashemi Rafsanjani - 13520105  
> Alifia Rahmah - 13520122

## Description

Folder Crawler is a program that crawls in your filesystem using `Breadth First Search` and `Depth First Search` to search file/files depends on your input.

## Requirements

- .NET Framework atleast 4.7.2
- MSBuild atleast 16.0 (Included when installing Visual Studio 2019)

## Usage

### Build

To build the program, follow these instructions

1. Open command line on `/src` directory
2. Run this command on the command line

```
msbuild
```

3. Run `FolderCrawler.exe` on `/bin` directory

### How to Use

1. Open FolderCrawler
2. Click `Change Directory` and choose start directory
3. Input target filename
4. Choose searching method between BFS and DFS
5. Input delay on visualizer
6. Choose layout to visualize graph
7. Click "Search"
8. Results will be shown on the application
