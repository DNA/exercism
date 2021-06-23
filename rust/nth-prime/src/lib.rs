pub fn is_prime(n: u32) -> bool {
    if n % 5 == 0 {
        return false;
    }

    let max_test_number = (n as f32).sqrt() as u32 + 1;

    for number in 3..max_test_number {
        if n % number == 0 {
            return false;
        }
    }

    return true;
}

pub fn nth(n: u32) -> u32 {
    let single_digit_primes = [2, 3, 5, 7];

    if n < 3 {
        return single_digit_primes[n as usize];
    }

    let mut prime_counter = 4;
    let mut possible_prime = 11;

    loop {
        if is_prime(possible_prime) {
            if prime_counter == n {
                return possible_prime;
            }

            prime_counter += 1;
        }

        // looping by two we skip even numbers
        possible_prime += 2;
    }
}
