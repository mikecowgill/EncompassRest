using System;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.RateLocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanRateLockTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task LoanGetRateLocks()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                await Task.Delay(1000);
                var rateLockApi = loan.LoanApis.RateLocks;
                var rateLocks = await rateLockApi.GetRateLocksAsync();
                Assert.IsNotNull(rateLocks);
                Assert.AreEqual(0, rateLocks.Count);
                var rateLockRequest = new RateLockRequest()
                {
                    LockRequest = new LockRequest()
                    {
                        LockDate = DateTime.Today,
                        LockNumberOfDays = 15
                    }
                };
                await rateLockApi.SubmitRateLockRequestAsync(rateLockRequest, true);
                var requestId = rateLockRequest.Id;
                Assert.IsFalse(string.IsNullOrEmpty(requestId));
                //Assert.AreEqual("6", addedCondition.OwnerRole.EntityId);
                //await Task.Delay(1000);
                //conditions = await underwritingConditions.GetConditionsAsync();
                //Assert.IsNotNull(conditions);
                //Assert.AreEqual(1, conditions.Count);
                //Assert.AreEqual(addedCondition.Title, conditions[0].Title);
                //Assert.AreEqual(addedCondition.Source.Value, conditions[0].Source.Value);
                //Assert.AreEqual(addedCondition.ForAllApplications, conditions[0].ForAllApplications);
                //AssertNoExtensionData(conditions[0], "Conditions[0]", conditions[0].Title, true);
                //var retrievedCondition = await underwritingConditions.GetConditionAsync(conditionId);
                //Assert.IsNotNull(retrievedCondition);
                //Assert.AreEqual(addedCondition.Title, retrievedCondition.Title);
                //Assert.AreEqual(addedCondition.Source.Value, retrievedCondition.Source.Value);
                //Assert.AreEqual(addedCondition.ForAllApplications, retrievedCondition.ForAllApplications);
                //AssertNoExtensionData(retrievedCondition, "RetrievedCondition", retrievedCondition.Title, true);
                //addedCondition.Title = "DEF";
                //await underwritingConditions.UpdateConditionsAsync(new[] { addedCondition });
                //await Task.Delay(1000);
                //retrievedCondition = await underwritingConditions.GetConditionAsync(conditionId);
                //Assert.AreEqual(addedCondition.Title, retrievedCondition.Title);
                //Assert.IsTrue(await underwritingConditions.DeleteConditionsAsync(new[] { conditionId }));
                //await Task.Delay(1000);
                //Assert.AreEqual(0, (await underwritingConditions.GetConditionsAsync()).Count);
            }
            finally
            {
                try
                {
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }

    }
}