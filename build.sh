#!/usr/bin/env bash

shopt -s globstar
mcs -out:main.exe -- **/*.cs
