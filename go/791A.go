package main

import (
	"fmt"
)

func main() {
	var a, b int
	fmt.Scan(&a, &b)

	years := 0
	for a <= b {
		a *= 3
		b *= 2
		years++
	}

	fmt.Println(years)
}
