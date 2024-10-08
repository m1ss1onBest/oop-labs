#include <iostream>
#include <format>
#include <string>
#include <memory>

class contract {
public:
    virtual void transfer(const std::string& to, unsigned long amount) = 0;
    virtual void details() const = 0;
    virtual ~contract() = default;
};

class nft : public contract {
    std::string symbol;
    std::string name;
    unsigned long id;

public:
    nft(const std::string& name, const std::string& symbol, unsigned long token_id)
        : symbol(symbol), name(name), id(token_id) {}

    void transfer(const std::string& to, unsigned long token_id) override {
        std::cout << std::format("NFT with id {} transferred to {}\n", token_id, to);
    }

    void details() const override {
        std::cout << std::format("ERC721 {} {} Token with id {}\n", symbol, name, id);
    }

    void mint() {
        ++id;
        std::cout << std::format("New ERC721 Token minted with id {}\n", id);
    }
};

class fungible_token : public contract {
    std::string symbol;
    std::string name;
    unsigned long supply;

public:
    fungible_token(const std::string& name, const std::string& symbol, unsigned long initial_supply)
        : symbol(symbol), name(name), supply(initial_supply) {}

    void transfer(const std::string& address, unsigned long amount) override {
        std::cout << std::format("Transferred {} tokens to {}\n", amount, address);
    }

    void details() const override {
        std::cout << std::format("ERC20 {} {} Token with {} supply\n", symbol, name, supply);
    }

    void mint(unsigned long amount, const std::string& address) {
        supply += amount;
        std::cout << std::format("Minted {} tokens to {}\n", amount, address);
    }

    ~fungible_token() override = default;
};

class token_factory {
public:
    virtual std::unique_ptr<contract> create_token() const = 0;
    virtual ~token_factory() = default;
};

class nft_token_factory : public token_factory {
    std::string name;
    std::string symbol;
    unsigned long id;

public:
    nft_token_factory(const std::string& name, const std::string& symbol, unsigned long token_id)
        : name(name), symbol(symbol), id(token_id) {}

    std::unique_ptr<contract> create_token() const override {
        return std::make_unique<nft>(name, symbol, id);
    }
};

class fungible_token_factory : public token_factory {
    std::string name;
    std::string symbol;
    unsigned long initial_supply;

public:
    fungible_token_factory(const std::string& name, const std::string& symbol, unsigned long initial_supply)
        : name(name), symbol(symbol), initial_supply(initial_supply) {}

    std::unique_ptr<contract> create_token() const override {
        return std::make_unique<fungible_token>(name, symbol, initial_supply);
    }
};

int main() {
    auto nft_factory = std::make_unique<nft_token_factory>("My NFT", "MN-FT", 1);
    auto nft_token = nft_factory->create_token();
    nft_token->details();
    nft_token->transfer("Someone else", 1);

    auto ft_factory = std::make_unique<fungible_token_factory>("My Token", "MTK", 10000000);
    auto ft_token = ft_factory->create_token();
    ft_token->details();
    
    return 0;
}
