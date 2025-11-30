n, m, a = gets.split.map(&:to_i)

tiles_n = (n + a - 1) / a
tiles_m = (m + a - 1) / a

puts tiles_n * tiles_m
