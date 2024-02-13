using Auction.API.Repositories;
using Microsoft.EntityFrameworkCore;
using AuctionEntity = Auction.API.Entities.Auction;

namespace Auction.API.UseCases.Auctions.GetCurrent
{
  public class GetCurrentAuctionUseCase
  {
    public AuctionEntity? Execute()
    {
      var repository = new AuctionDbContext();
      var today = DateTime.Now;

      return repository.Auctions
        .Include(auction => auction.Items)
        .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
  }
}
